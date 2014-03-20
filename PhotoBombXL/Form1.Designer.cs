namespace PhotoBombXL
{
    partial class Form1
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
            this.lstProfileList = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblFileType = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblAspectHeight = new System.Windows.Forms.Label();
            this.lblAspectWidth = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtFileType = new System.Windows.Forms.TextBox();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.txtAspectHeight = new System.Windows.Forms.TextBox();
            this.txtAspectWidth = new System.Windows.Forms.TextBox();
            this.lblExifMaintained = new System.Windows.Forms.Label();
            this.txtExifMaintained = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstProfileList
            // 
            this.lstProfileList.BackColor = System.Drawing.SystemColors.Window;
            this.lstProfileList.FormattingEnabled = true;
            this.lstProfileList.Location = new System.Drawing.Point(274, 92);
            this.lstProfileList.Name = "lstProfileList";
            this.lstProfileList.Size = new System.Drawing.Size(180, 225);
            this.lstProfileList.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(274, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Profiles";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(367, 323);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(87, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Profiles";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.Location = new System.Drawing.Point(510, 322);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(103, 23);
            this.btnCreateProfile.TabIndex = 3;
            this.btnCreateProfile.Text = "Create Profile";
            this.btnCreateProfile.UseVisualStyleBackColor = true;
            this.btnCreateProfile.Click += new System.EventHandler(this.btnCreateProfile_Click);
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Location = new System.Drawing.Point(470, 92);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(67, 13);
            this.lblProfileName.TabIndex = 4;
            this.lblProfileName.Text = "Profile Name";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(550, 92);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(85, 20);
            this.txtProfileName.TabIndex = 5;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(470, 126);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(470, 158);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = "Width";
            // 
            // lblFileType
            // 
            this.lblFileType.AutoSize = true;
            this.lblFileType.Location = new System.Drawing.Point(470, 186);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(50, 13);
            this.lblFileType.TabIndex = 8;
            this.lblFileType.Text = "File Type";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(470, 214);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(46, 13);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "File Size";
            // 
            // lblAspectHeight
            // 
            this.lblAspectHeight.AutoSize = true;
            this.lblAspectHeight.Location = new System.Drawing.Point(470, 245);
            this.lblAspectHeight.Name = "lblAspectHeight";
            this.lblAspectHeight.Size = new System.Drawing.Size(74, 13);
            this.lblAspectHeight.TabIndex = 10;
            this.lblAspectHeight.Text = "Aspect Height";
            // 
            // lblAspectWidth
            // 
            this.lblAspectWidth.AutoSize = true;
            this.lblAspectWidth.Location = new System.Drawing.Point(470, 271);
            this.lblAspectWidth.Name = "lblAspectWidth";
            this.lblAspectWidth.Size = new System.Drawing.Size(71, 13);
            this.lblAspectWidth.TabIndex = 11;
            this.lblAspectWidth.Text = "Aspect Width";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(551, 126);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(85, 20);
            this.txtHeight.TabIndex = 12;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(551, 160);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(85, 20);
            this.txtWidth.TabIndex = 13;
            // 
            // txtFileType
            // 
            this.txtFileType.Location = new System.Drawing.Point(550, 186);
            this.txtFileType.Name = "txtFileType";
            this.txtFileType.Size = new System.Drawing.Size(85, 20);
            this.txtFileType.TabIndex = 14;
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(550, 214);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(85, 20);
            this.txtFileSize.TabIndex = 15;
            // 
            // txtAspectHeight
            // 
            this.txtAspectHeight.Location = new System.Drawing.Point(550, 245);
            this.txtAspectHeight.Name = "txtAspectHeight";
            this.txtAspectHeight.Size = new System.Drawing.Size(85, 20);
            this.txtAspectHeight.TabIndex = 16;
            // 
            // txtAspectWidth
            // 
            this.txtAspectWidth.Location = new System.Drawing.Point(550, 271);
            this.txtAspectWidth.Name = "txtAspectWidth";
            this.txtAspectWidth.Size = new System.Drawing.Size(85, 20);
            this.txtAspectWidth.TabIndex = 17;
            // 
            // lblExifMaintained
            // 
            this.lblExifMaintained.AutoSize = true;
            this.lblExifMaintained.Location = new System.Drawing.Point(470, 300);
            this.lblExifMaintained.Name = "lblExifMaintained";
            this.lblExifMaintained.Size = new System.Drawing.Size(76, 13);
            this.lblExifMaintained.TabIndex = 18;
            this.lblExifMaintained.Text = "ExifMaintained";
            // 
            // txtExifMaintained
            // 
            this.txtExifMaintained.Location = new System.Drawing.Point(550, 300);
            this.txtExifMaintained.Name = "txtExifMaintained";
            this.txtExifMaintained.Size = new System.Drawing.Size(85, 20);
            this.txtExifMaintained.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 458);
            this.Controls.Add(this.txtExifMaintained);
            this.Controls.Add(this.lblExifMaintained);
            this.Controls.Add(this.txtAspectWidth);
            this.Controls.Add(this.txtAspectHeight);
            this.Controls.Add(this.txtFileSize);
            this.Controls.Add(this.txtFileType);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblAspectWidth);
            this.Controls.Add(this.lblAspectHeight);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblFileType);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtProfileName);
            this.Controls.Add(this.lblProfileName);
            this.Controls.Add(this.btnCreateProfile);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstProfileList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProfileList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblAspectHeight;
        private System.Windows.Forms.Label lblAspectWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtFileType;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.TextBox txtAspectHeight;
        private System.Windows.Forms.TextBox txtAspectWidth;
        private System.Windows.Forms.Label lblExifMaintained;
        private System.Windows.Forms.TextBox txtExifMaintained;
    }
}

