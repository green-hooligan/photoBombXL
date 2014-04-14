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
            this.components = new System.ComponentModel.Container();
            this.lstProfileList = new System.Windows.Forms.ListBox();
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
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.txtAspectHeight = new System.Windows.Forms.TextBox();
            this.txtAspectWidth = new System.Windows.Forms.TextBox();
            this.lblExifMaintained = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowseSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstFilesInDirList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFileType = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnBrowseSave = new System.Windows.Forms.Button();
            this.txtSaveDirectory = new System.Windows.Forms.TextBox();
            this.chkDefaultSave = new System.Windows.Forms.CheckBox();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.cmbExifMaintained = new System.Windows.Forms.ComboBox();
            this.profileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstProfileList
            // 
            this.lstProfileList.BackColor = System.Drawing.SystemColors.Window;
            this.lstProfileList.FormattingEnabled = true;
            this.lstProfileList.Location = new System.Drawing.Point(17, 130);
            this.lstProfileList.Name = "lstProfileList";
            this.lstProfileList.Size = new System.Drawing.Size(248, 238);
            this.lstProfileList.TabIndex = 0;
            this.lstProfileList.SelectedIndexChanged += new System.EventHandler(this.lstProfileList_SelectedIndexChanged);
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.Location = new System.Drawing.Point(45, 234);
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
            this.lblProfileName.Location = new System.Drawing.Point(6, 26);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(67, 13);
            this.lblProfileName.TabIndex = 4;
            this.lblProfileName.Text = "Profile Name";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(86, 26);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(85, 20);
            this.txtProfileName.TabIndex = 5;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(6, 52);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(6, 78);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = "Width";
            // 
            // lblFileType
            // 
            this.lblFileType.AutoSize = true;
            this.lblFileType.Location = new System.Drawing.Point(6, 104);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(50, 13);
            this.lblFileType.TabIndex = 8;
            this.lblFileType.Text = "File Type";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(6, 130);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(46, 13);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "File Size";
            // 
            // lblAspectHeight
            // 
            this.lblAspectHeight.AutoSize = true;
            this.lblAspectHeight.Location = new System.Drawing.Point(6, 156);
            this.lblAspectHeight.Name = "lblAspectHeight";
            this.lblAspectHeight.Size = new System.Drawing.Size(74, 13);
            this.lblAspectHeight.TabIndex = 10;
            this.lblAspectHeight.Text = "Aspect Height";
            // 
            // lblAspectWidth
            // 
            this.lblAspectWidth.AutoSize = true;
            this.lblAspectWidth.Location = new System.Drawing.Point(6, 182);
            this.lblAspectWidth.Name = "lblAspectWidth";
            this.lblAspectWidth.Size = new System.Drawing.Size(71, 13);
            this.lblAspectWidth.TabIndex = 11;
            this.lblAspectWidth.Text = "Aspect Width";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(87, 52);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(85, 20);
            this.txtHeight.TabIndex = 12;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(87, 78);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(85, 20);
            this.txtWidth.TabIndex = 13;
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(87, 130);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(85, 20);
            this.txtFileSize.TabIndex = 15;
            // 
            // txtAspectHeight
            // 
            this.txtAspectHeight.Location = new System.Drawing.Point(87, 156);
            this.txtAspectHeight.Name = "txtAspectHeight";
            this.txtAspectHeight.Size = new System.Drawing.Size(85, 20);
            this.txtAspectHeight.TabIndex = 16;
            // 
            // txtAspectWidth
            // 
            this.txtAspectWidth.Location = new System.Drawing.Point(87, 182);
            this.txtAspectWidth.Name = "txtAspectWidth";
            this.txtAspectWidth.Size = new System.Drawing.Size(85, 20);
            this.txtAspectWidth.TabIndex = 17;
            // 
            // lblExifMaintained
            // 
            this.lblExifMaintained.AutoSize = true;
            this.lblExifMaintained.Location = new System.Drawing.Point(6, 208);
            this.lblExifMaintained.Name = "lblExifMaintained";
            this.lblExifMaintained.Size = new System.Drawing.Size(76, 13);
            this.lblExifMaintained.TabIndex = 18;
            this.lblExifMaintained.Text = "ExifMaintained";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select Directory";
            // 
            // txtSelectDirectory
            // 
            this.txtSelectDirectory.Location = new System.Drawing.Point(12, 29);
            this.txtSelectDirectory.Name = "txtSelectDirectory";
            this.txtSelectDirectory.Size = new System.Drawing.Size(176, 20);
            this.txtSelectDirectory.TabIndex = 21;
            // 
            // btnBrowseSelect
            // 
            this.btnBrowseSelect.Location = new System.Drawing.Point(194, 29);
            this.btnBrowseSelect.Name = "btnBrowseSelect";
            this.btnBrowseSelect.Size = new System.Drawing.Size(74, 23);
            this.btnBrowseSelect.TabIndex = 22;
            this.btnBrowseSelect.Text = "Browse";
            this.btnBrowseSelect.UseVisualStyleBackColor = true;
            this.btnBrowseSelect.Click += new System.EventHandler(this.btnBrowseSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Selected Directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Save Directory";
            // 
            // lstFilesInDirList
            // 
            this.lstFilesInDirList.BackColor = System.Drawing.SystemColors.Window;
            this.lstFilesInDirList.FormattingEnabled = true;
            this.lstFilesInDirList.Location = new System.Drawing.Point(282, 39);
            this.lstFilesInDirList.Name = "lstFilesInDirList";
            this.lstFilesInDirList.Size = new System.Drawing.Size(250, 329);
            this.lstFilesInDirList.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbExifMaintained);
            this.groupBox1.Controls.Add(this.cmbFileType);
            this.groupBox1.Controls.Add(this.lblProfileName);
            this.groupBox1.Controls.Add(this.btnCreateProfile);
            this.groupBox1.Controls.Add(this.txtProfileName);
            this.groupBox1.Controls.Add(this.lblHeight);
            this.groupBox1.Controls.Add(this.lblWidth);
            this.groupBox1.Controls.Add(this.lblFileType);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Controls.Add(this.lblAspectHeight);
            this.groupBox1.Controls.Add(this.lblAspectWidth);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.lblExifMaintained);
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.txtAspectWidth);
            this.groupBox1.Controls.Add(this.txtAspectHeight);
            this.groupBox1.Controls.Add(this.txtFileSize);
            this.groupBox1.Location = new System.Drawing.Point(548, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 265);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cmbFileType
            // 
            this.cmbFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFileType.FormattingEnabled = true;
            this.cmbFileType.Location = new System.Drawing.Point(87, 103);
            this.cmbFileType.Name = "cmbFileType";
            this.cmbFileType.Size = new System.Drawing.Size(85, 21);
            this.cmbFileType.TabIndex = 20;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 406);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(829, 23);
            this.progressBar1.TabIndex = 29;
            // 
            // btnBrowseSave
            // 
            this.btnBrowseSave.Location = new System.Drawing.Point(194, 81);
            this.btnBrowseSave.Name = "btnBrowseSave";
            this.btnBrowseSave.Size = new System.Drawing.Size(74, 23);
            this.btnBrowseSave.TabIndex = 31;
            this.btnBrowseSave.Text = "Browse";
            this.btnBrowseSave.UseVisualStyleBackColor = true;
            this.btnBrowseSave.Click += new System.EventHandler(this.btnBrowseSave_Click);
            // 
            // txtSaveDirectory
            // 
            this.txtSaveDirectory.Location = new System.Drawing.Point(12, 81);
            this.txtSaveDirectory.Name = "txtSaveDirectory";
            this.txtSaveDirectory.Size = new System.Drawing.Size(176, 20);
            this.txtSaveDirectory.TabIndex = 30;
            // 
            // chkDefaultSave
            // 
            this.chkDefaultSave.AutoSize = true;
            this.chkDefaultSave.Location = new System.Drawing.Point(16, 107);
            this.chkDefaultSave.Name = "chkDefaultSave";
            this.chkDefaultSave.Size = new System.Drawing.Size(106, 17);
            this.chkDefaultSave.TabIndex = 32;
            this.chkDefaultSave.Text = "Use default save";
            this.chkDefaultSave.UseVisualStyleBackColor = true;
            this.chkDefaultSave.CheckedChanged += new System.EventHandler(this.chkDefaultSave_CheckedChanged);
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.Location = new System.Drawing.Point(16, 374);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(92, 23);
            this.btnDeleteProfile.TabIndex = 33;
            this.btnDeleteProfile.Text = "Delete Profile";
            this.btnDeleteProfile.UseVisualStyleBackColor = true;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // cmbExifMaintained
            // 
            this.cmbExifMaintained.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExifMaintained.FormattingEnabled = true;
            this.cmbExifMaintained.Location = new System.Drawing.Point(86, 205);
            this.cmbExifMaintained.Name = "cmbExifMaintained";
            this.cmbExifMaintained.Size = new System.Drawing.Size(85, 21);
            this.cmbExifMaintained.TabIndex = 34;
            // 
            // profileBindingSource
            // 
            this.profileBindingSource.DataSource = typeof(PhotoBombXL.Profile);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 441);
            this.Controls.Add(this.btnDeleteProfile);
            this.Controls.Add(this.chkDefaultSave);
            this.Controls.Add(this.btnBrowseSave);
            this.Controls.Add(this.txtSaveDirectory);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstFilesInDirList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseSelect);
            this.Controls.Add(this.txtSelectDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProfileList);
            this.Name = "Form1";
            this.Text = "Photo Bomber XL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProfileList;
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
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.TextBox txtAspectHeight;
        private System.Windows.Forms.TextBox txtAspectWidth;
        private System.Windows.Forms.Label lblExifMaintained;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelectDirectory;
        private System.Windows.Forms.Button btnBrowseSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstFilesInDirList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnBrowseSave;
        private System.Windows.Forms.TextBox txtSaveDirectory;
        private System.Windows.Forms.CheckBox chkDefaultSave;
        private System.Windows.Forms.ComboBox cmbFileType;
        private System.Windows.Forms.BindingSource profileBindingSource;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.ComboBox cmbExifMaintained;
    }
}

