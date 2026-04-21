namespace EncryptionFiles
{
    partial class frmAddNewFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rbPhoto = new System.Windows.Forms.RadioButton();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.rbAudio = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filte Type : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbPhoto
            // 
            this.rbPhoto.AutoSize = true;
            this.rbPhoto.Location = new System.Drawing.Point(151, 39);
            this.rbPhoto.Name = "rbPhoto";
            this.rbPhoto.Size = new System.Drawing.Size(66, 21);
            this.rbPhoto.TabIndex = 1;
            this.rbPhoto.TabStop = true;
            this.rbPhoto.Text = "Photo";
            this.rbPhoto.UseVisualStyleBackColor = true;
            this.rbPhoto.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.Location = new System.Drawing.Point(271, 39);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(62, 21);
            this.rbVideo.TabIndex = 2;
            this.rbVideo.TabStop = true;
            this.rbVideo.Text = "Video";
            this.rbVideo.UseVisualStyleBackColor = true;
            this.rbVideo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbAudio
            // 
            this.rbAudio.AutoSize = true;
            this.rbAudio.Location = new System.Drawing.Point(391, 39);
            this.rbAudio.Name = "rbAudio";
            this.rbAudio.Size = new System.Drawing.Size(63, 21);
            this.rbAudio.TabIndex = 3;
            this.rbAudio.TabStop = true;
            this.rbAudio.Text = "Audio";
            this.rbAudio.UseVisualStyleBackColor = true;
            this.rbAudio.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddNewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(752, 515);
            this.Controls.Add(this.rbAudio);
            this.Controls.Add(this.rbVideo);
            this.Controls.Add(this.rbPhoto);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddNewFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPhoto;
        private System.Windows.Forms.RadioButton rbVideo;
        private System.Windows.Forms.RadioButton rbAudio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}