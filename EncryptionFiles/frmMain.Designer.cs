namespace EncryptionFiles
{
    partial class frmMain
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
            this.label2 = new System.Windows.Forms.Label();
            this.flpDialog = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pbGallery = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pbVideo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.pbAudio = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sittingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.flpDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGallery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAudio)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save The";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label2.Location = new System.Drawing.Point(606, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Flow";
            // 
            // flpDialog
            // 
            this.flpDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.flpDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDialog.Controls.Add(this.splitContainer1);
            this.flpDialog.Controls.Add(this.splitContainer2);
            this.flpDialog.Controls.Add(this.splitContainer3);
            this.flpDialog.Location = new System.Drawing.Point(12, 105);
            this.flpDialog.Name = "flpDialog";
            this.flpDialog.Size = new System.Drawing.Size(1134, 582);
            this.flpDialog.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pbGallery);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(125, 114);
            this.splitContainer1.SplitterDistance = 85;
            this.splitContainer1.TabIndex = 3;
            // 
            // pbGallery
            // 
            this.pbGallery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGallery.Image = global::EncryptionFiles.Properties.Resources.folder;
            this.pbGallery.Location = new System.Drawing.Point(0, 0);
            this.pbGallery.Name = "pbGallery";
            this.pbGallery.Size = new System.Drawing.Size(125, 85);
            this.pbGallery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGallery.TabIndex = 0;
            this.pbGallery.TabStop = false;
            this.pbGallery.Click += new System.EventHandler(this.pbGallery_Click);
            this.pbGallery.DoubleClick += new System.EventHandler(this.pbGallery_DoubleClick);
            this.pbGallery.MouseEnter += new System.EventHandler(this.pbGallery_MouseEnter);
            this.pbGallery.MouseLeave += new System.EventHandler(this.pbGallery_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gallery";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(134, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pbVideo);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Size = new System.Drawing.Size(125, 114);
            this.splitContainer2.SplitterDistance = 85;
            this.splitContainer2.TabIndex = 4;
            // 
            // pbVideo
            // 
            this.pbVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbVideo.Image = global::EncryptionFiles.Properties.Resources.folder;
            this.pbVideo.Location = new System.Drawing.Point(0, 0);
            this.pbVideo.Name = "pbVideo";
            this.pbVideo.Size = new System.Drawing.Size(125, 85);
            this.pbVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVideo.TabIndex = 1;
            this.pbVideo.TabStop = false;
            this.pbVideo.Click += new System.EventHandler(this.pbVideo_Click);
            this.pbVideo.DoubleClick += new System.EventHandler(this.pbVideo_DoubleClick);
            this.pbVideo.MouseEnter += new System.EventHandler(this.pbVideo_MouseEnter);
            this.pbVideo.MouseLeave += new System.EventHandler(this.pbVideo_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Video";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Location = new System.Drawing.Point(265, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.pbAudio);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label5);
            this.splitContainer3.Size = new System.Drawing.Size(125, 114);
            this.splitContainer3.SplitterDistance = 85;
            this.splitContainer3.TabIndex = 5;
            // 
            // pbAudio
            // 
            this.pbAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAudio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAudio.Image = global::EncryptionFiles.Properties.Resources.folder;
            this.pbAudio.Location = new System.Drawing.Point(0, 0);
            this.pbAudio.Name = "pbAudio";
            this.pbAudio.Size = new System.Drawing.Size(125, 85);
            this.pbAudio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAudio.TabIndex = 2;
            this.pbAudio.TabStop = false;
            this.pbAudio.DoubleClick += new System.EventHandler(this.pbAudio_DoubleClick);
            this.pbAudio.MouseEnter += new System.EventHandler(this.pbAudio_MouseEnter);
            this.pbAudio.MouseLeave += new System.EventHandler(this.pbAudio_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Audio";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sittingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1158, 36);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sittingsToolStripMenuItem
            // 
            this.sittingsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sittingsToolStripMenuItem.Name = "sittingsToolStripMenuItem";
            this.sittingsToolStripMenuItem.Size = new System.Drawing.Size(94, 32);
            this.sittingsToolStripMenuItem.Text = "settings";
            this.sittingsToolStripMenuItem.Click += new System.EventHandler(this.sittingsToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::EncryptionFiles.Properties.Resources.addfolders;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(1071, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 62);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1158, 699);
            this.Controls.Add(this.flpDialog);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save The Flow";
            this.flpDialog.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGallery)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAudio)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flpDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sittingsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbVideo;
        private System.Windows.Forms.PictureBox pbAudio;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pbGallery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label5;
    }
}

