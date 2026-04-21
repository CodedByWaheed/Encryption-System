using EncryptionFiles.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace EncryptionFiles
{
    public partial class frmMain: Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        enum enDataType { Photo = 1 , Video = 2 , Audio = 3}
        private void _LoadData(enDataType Type)
        {
            switch (Type) 
            {
                case enDataType.Photo:

                    break;
                case enDataType.Video: 
                    
                    break;
                case enDataType.Audio:
                    
                    break;
            }
        }
       

      

        private void pbAudio_MouseEnter(object sender, EventArgs e)
        {
            pbAudio.Image = Resources.open_folder;
        }

        private void pbAudio_MouseLeave(object sender, EventArgs e)
        {
            pbAudio.Image = Resources.folder;
        }

        private void pbVideo_MouseEnter(object sender, EventArgs e)
        {
            pbVideo.Image = Resources.open_folder;
        }

        private void pbVideo_MouseLeave(object sender, EventArgs e)
        {
            pbVideo.Image = Resources.folder;
        }

        private void pbGallery_MouseEnter(object sender, EventArgs e)
        {
            pbGallery.Image = Resources.open_folder;
        }

        private void pbGallery_MouseLeave(object sender, EventArgs e)
        {
            pbGallery.Image = Resources.folder;
        }

        string Key = "1234567890123456";
        private void btnAdd_Click(object sender, EventArgs e)
        {
           

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a file";
                //"Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff;*.webp)|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff;*.webp"
                //"Video Files (*.mp4;*.avi;*.mkv;*.mov;*.wmv;*.flv;*.webm;*.mpeg;*.mpg)|*.mp4;*.avi;*.mkv;*.mov;*.wmv;*.flv;*.webm;*.mpeg;*.mpg"
                //"Audio Files (*.mp3;*.wav;*.aac;*.flac;*.ogg;*.wma;*.m4a)|*.mp3;*.wav;*.aac;*.flac;*.ogg;*.wma;*.m4a"
                openFileDialog.Filter =
                                    "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|" +
                                    "Video Files|*.mp4;*.avi;*.mkv;*.mov|" +
                                    "Audio Files|*.mp3;*.wav;*.aac|" +
                                    "All files (*.*)|*.*";
                openFileDialog.Multiselect = false;
                //openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    switch (clsUtility.CompareFileType(filePath))
                    {
                        case clsUtility.enFileType.Images:
                            clsUtility.CopyFileToEncryptionFolder(filePath,Key , clsUtility.enFileType.Images);
                            break;
                        case clsUtility.enFileType.Videos:
                            clsUtility.CopyFileToEncryptionFolder(filePath,Key, clsUtility.enFileType.Videos);   
                            break;
                        case clsUtility.enFileType.audio:
                            clsUtility.CopyFileToEncryptionFolder(filePath,Key, clsUtility.enFileType.audio);      
                            break;
                            
                    }
                    
                }
            }

        }

        private void sittingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmSetting frm = new frmSetting();
            frm.ShowDialog();
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(26, 30, 41);
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
        }
      

        private void FetchFiles(string Path)
        {
            var files = Directory.EnumerateFiles(Path);
            foreach (var file in files)
            {
               
                string outputFile = clsUtility.CreatName(ConfigurationManager.AppSettings["DFiles"], file);
                clsUtility.DecryptFile(file, outputFile, Key);

                ctrlImage ctrl = new ctrlImage();
                ctrl.Source(outputFile);
                ctrl.DoupleClickOnPicturePox += Ctrl_DoupleClickOnPicturePox;
                flpDialog.Controls.Add(ctrl);
            }
        }

        private void Ctrl_DoupleClickOnPicturePox(object sender, ctrlImage.PicturPoxEventArgs e)
        {
            ctrlImage ctrl = (ctrlImage)sender;
            frmInspectImage frm = new frmInspectImage(ctrl.ImageLocation);
            frm.Show();
        }

        private void Ctrl_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void pbGallery_DoubleClick(object sender, EventArgs e)
        {
            flpDialog.Controls.Clear();
            FetchFiles(ConfigurationManager.AppSettings["Images"]);
        }

        private void pbVideo_DoubleClick(object sender, EventArgs e)
        {
            flpDialog.Controls.Clear();
            FetchFiles(ConfigurationManager.AppSettings["Videos"]);
        }

        private void pbAudio_DoubleClick(object sender, EventArgs e)
        {
            flpDialog.Controls.Clear();
            FetchFiles(ConfigurationManager.AppSettings["Audios"]);
        }
    }
}
