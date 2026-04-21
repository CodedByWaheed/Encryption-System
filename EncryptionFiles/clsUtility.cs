using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;

namespace EncryptionFiles
{
    class clsUtility
    {
        private static string GenerateGUID()
        {

            // Generate a new GUID
            Guid newGuid = Guid.NewGuid();

            // convert the GUID to a string
            return newGuid.ToString();

        }
        
        // CreateHiddenFolderIfDoesNotExist(string FolderPath)
        private static bool CreateFolderIfDoesNotExist(string FolderPath, bool Hidden = false)
        {

            // Check if the folder exists
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    // If it doesn't exist, create the folder
                    Directory.CreateDirectory(FolderPath);
                    if(Hidden) 
                        File.SetAttributes(FolderPath, FileAttributes.Hidden);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;

        }

        private static string ReplaceFileNameWithGUID(string sourceFile)
        {
            // Full file name. Change your file name   
            string fileName = sourceFile;
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;
            return GenerateGUID() + extn;

        }

        public enum enFileType { Images = 1 , Videos = 2 , audio = 3, Garbage = 4}
        
        public static bool CopyFileToEncryptionFolder(string sourceFile,string Key , enFileType FileType)
        {
            // this funciton will copy the image to the
            // project images foldr after renaming it
            // with GUID with the same extention, then it will update the sourceFileName with the new name.
            string DestinationFolder ;
            switch (FileType)
            {
               
                case enFileType.Images:
                     DestinationFolder = ConfigurationManager.AppSettings["Images"];
                    break;
                case enFileType.Videos:
                     DestinationFolder = ConfigurationManager.AppSettings["Videos"];
                    break;
                case enFileType.audio:
                     DestinationFolder = ConfigurationManager.AppSettings["Audios"];
                    break;
                default:
                     DestinationFolder = ConfigurationManager.AppSettings["Garbage"];
                    break ;
            }
           
            if (!CreateFolderIfDoesNotExist(DestinationFolder, true))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                byte[] iv;
                using (Aes aesAlg = Aes.Create())
                {
                    iv = aesAlg.IV;
                }
                File.WriteAllBytes(destinationFile, iv);
                EncryptFile(sourceFile, destinationFile, Key, iv);
                
            }
            catch (IOException iox)
            {
                if (!EventLog.SourceExists(ConfigurationManager.AppSettings["AppName"]))
                {
                    EventLog.CreateEventSource(ConfigurationManager.AppSettings["AppName"], "Application");
                }
                EventLog.WriteEntry(ConfigurationManager.AppSettings["AppName"], $"{iox} : from Fun CopyFileToEncryptionFolder", EventLogEntryType.Error);
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }



        static List<string> ImageExtn = new List<string> { ".jpg", ".jpeg",".png",".bmp" ,".gif" };
        static List<string> VideoExtn = new List<string> { ".mp4", ".avi", ".mkv", ".mov" };
        static List<string> AudioExtn = new List<string> { ".mp3", ".wav", ".aac" };
        /// <summary>
        /// a function that Compare the extension of any path to find its type
        /// </summary>
        /// <param name="FilePath"> this the file Path</param>
        /// <returns>the type of the file (image , vedio , audio)</returns>
        public static enFileType CompareFileType(string FilePath)
        {
            FileInfo f = new FileInfo(FilePath);

            foreach (string extn in ImageExtn)
            {
                if (f.Extension == extn)
                    return enFileType.Images;
            }
            foreach (string extn in VideoExtn)
            {
                if (f.Extension == extn)
                    return enFileType.Videos;
            }
            foreach (string extn in AudioExtn)
            {
                if (f.Extension == extn)
                    return enFileType.audio;
            }

            return enFileType.Garbage;
        }


        public static string ComputeHashing(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashByte = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                return BitConverter.ToString(hashByte).Replace("-", "").ToLower();
            }

        }

        public static void EncryptFile(string inputFile, string outputFile, string key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = System.Text.Encoding.UTF8.GetBytes(key);
                aesAlg.IV = iv;

                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())
                using (CryptoStream cryptoStream = new CryptoStream(fsOutput, encryptor, CryptoStreamMode.Write))
                {
                    // Write the IV to the beginning of the file
                    fsOutput.Write(iv, 0, iv.Length);
                    fsInput.CopyTo(cryptoStream);
                    // i add this line
                    cryptoStream.FlushFinalBlock();
                }
            }
        }
        public static void DecryptFile(string inputFile, string outputFile, string key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = System.Text.Encoding.UTF8.GetBytes(key);
                aesAlg.IV = iv;

                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                using (ICryptoTransform decryptor = aesAlg.CreateDecryptor())
                using (CryptoStream cryptoStream = new CryptoStream(fsOutput, decryptor, CryptoStreamMode.Write))
                {
                    // Skip the IV at the beginning of the file
                    fsInput.Seek(iv.Length, SeekOrigin.Begin);
                    fsInput.CopyTo(cryptoStream);
                }
            }
        }
        public static string CreatName(string Path , string Image)
        {
            if(CreateFolderIfDoesNotExist(Path , true))
                return Path + ReplaceFileNameWithGUID(Image);
            return "";
        }
        public static void DecryptFile(string inputFile, string outputFile, string key)
        {
            byte[] fileData = File.ReadAllBytes(inputFile);

            byte[] iv = fileData.Take(16).ToArray();
            byte[] cipher = fileData.Skip(16).ToArray();
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = System.Text.Encoding.UTF8.GetBytes(key);
                aesAlg.IV = iv;

                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                using (ICryptoTransform decryptor = aesAlg.CreateDecryptor())
                using (CryptoStream cryptoStream = new CryptoStream(fsOutput, decryptor, CryptoStreamMode.Write))
                {
                    // Skip the IV at the beginning of the file
                    fsInput.Seek(iv.Length, SeekOrigin.Begin);
                    fsInput.CopyTo(cryptoStream);
                }
            }
        }
    }
}
