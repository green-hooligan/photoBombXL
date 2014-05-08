﻿namespace PhotoBombXL
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
            this.lstProfile = new System.Windows.Forms.ListBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnCancelProfile = new System.Windows.Forms.Button();
            this.cmbFileSize = new System.Windows.Forms.ComboBox();
            this.cmbExifMaintained = new System.Windows.Forms.ComboBox();
            this.cmbFileType = new System.Windows.Forms.ComboBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.prgProgressBar = new System.Windows.Forms.ProgressBar();
            this.btnBrowseSave = new System.Windows.Forms.Button();
            this.txtSaveDirectory = new System.Windows.Forms.TextBox();
            this.chkDefaultSave = new System.Windows.Forms.CheckBox();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.pctrPreviewImage = new System.Windows.Forms.PictureBox();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.chklstFiles = new System.Windows.Forms.CheckedListBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrPreviewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lstProfile
            // 
            this.lstProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProfile.BackColor = System.Drawing.SystemColors.Window;
            this.lstProfile.FormattingEnabled = true;
            this.lstProfile.Location = new System.Drawing.Point(274, 27);
            this.lstProfile.Name = "lstProfile";
            this.lstProfile.Size = new System.Drawing.Size(248, 251);
            this.lstProfile.TabIndex = 0;
            this.lstProfile.SelectedIndexChanged += new System.EventHandler(this.lstProfileList_SelectedIndexChanged);
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.Location = new System.Drawing.Point(6, 234);
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
            this.txtProfileName.ReadOnly = true;
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
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(85, 20);
            this.txtHeight.TabIndex = 12;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(87, 78);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.ReadOnly = true;
            this.txtWidth.Size = new System.Drawing.Size(85, 20);
            this.txtWidth.TabIndex = 13;
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(87, 130);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.ReadOnly = true;
            this.txtFileSize.Size = new System.Drawing.Size(85, 20);
            this.txtFileSize.TabIndex = 15;
            // 
            // txtAspectHeight
            // 
            this.txtAspectHeight.Location = new System.Drawing.Point(87, 156);
            this.txtAspectHeight.Name = "txtAspectHeight";
            this.txtAspectHeight.ReadOnly = true;
            this.txtAspectHeight.Size = new System.Drawing.Size(85, 20);
            this.txtAspectHeight.TabIndex = 16;
            // 
            // txtAspectWidth
            // 
            this.txtAspectWidth.Location = new System.Drawing.Point(87, 182);
            this.txtAspectWidth.Name = "txtAspectWidth";
            this.txtAspectWidth.ReadOnly = true;
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
            this.txtSelectDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectDirectory.Location = new System.Drawing.Point(12, 29);
            this.txtSelectDirectory.Name = "txtSelectDirectory";
            this.txtSelectDirectory.Size = new System.Drawing.Size(176, 20);
            this.txtSelectDirectory.TabIndex = 21;
            this.txtSelectDirectory.TextChanged += new System.EventHandler(this.txtSelectDirectory_TextChanged);
            // 
            // btnBrowseSelect
            // 
            this.btnBrowseSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Profile List";
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnEditProfile);
            this.groupBox1.Controls.Add(this.btnCancelProfile);
            this.groupBox1.Controls.Add(this.cmbFileSize);
            this.groupBox1.Controls.Add(this.cmbExifMaintained);
            this.groupBox1.Controls.Add(this.btnCreateProfile);
            this.groupBox1.Controls.Add(this.cmbFileType);
            this.groupBox1.Controls.Add(this.lblProfileName);
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
            this.groupBox1.Controls.Add(this.btnSaveProfile);
            this.groupBox1.Location = new System.Drawing.Point(548, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 265);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile Information";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(131, 234);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(103, 23);
            this.btnEditProfile.TabIndex = 38;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnCancelProfile
            // 
            this.btnCancelProfile.Location = new System.Drawing.Point(131, 234);
            this.btnCancelProfile.Name = "btnCancelProfile";
            this.btnCancelProfile.Size = new System.Drawing.Size(103, 23);
            this.btnCancelProfile.TabIndex = 37;
            this.btnCancelProfile.Text = "Cancel";
            this.btnCancelProfile.UseVisualStyleBackColor = true;
            this.btnCancelProfile.Visible = false;
            this.btnCancelProfile.Click += new System.EventHandler(this.btnCancelProfile_Click);
            // 
            // cmbFileSize
            // 
            this.cmbFileSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFileSize.Enabled = false;
            this.cmbFileSize.FormattingEnabled = true;
            this.cmbFileSize.Location = new System.Drawing.Point(178, 130);
            this.cmbFileSize.Name = "cmbFileSize";
            this.cmbFileSize.Size = new System.Drawing.Size(85, 21);
            this.cmbFileSize.TabIndex = 35;
            // 
            // cmbExifMaintained
            // 
            this.cmbExifMaintained.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExifMaintained.Enabled = false;
            this.cmbExifMaintained.FormattingEnabled = true;
            this.cmbExifMaintained.Location = new System.Drawing.Point(86, 205);
            this.cmbExifMaintained.Name = "cmbExifMaintained";
            this.cmbExifMaintained.Size = new System.Drawing.Size(85, 21);
            this.cmbExifMaintained.TabIndex = 34;
            // 
            // cmbFileType
            // 
            this.cmbFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFileType.Enabled = false;
            this.cmbFileType.FormattingEnabled = true;
            this.cmbFileType.Location = new System.Drawing.Point(87, 103);
            this.cmbFileType.Name = "cmbFileType";
            this.cmbFileType.Size = new System.Drawing.Size(85, 21);
            this.cmbFileType.TabIndex = 20;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(6, 234);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(103, 23);
            this.btnSaveProfile.TabIndex = 36;
            this.btnSaveProfile.Text = "Save";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Visible = false;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // prgProgressBar
            // 
            this.prgProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgProgressBar.Location = new System.Drawing.Point(12, 403);
            this.prgProgressBar.Name = "prgProgressBar";
            this.prgProgressBar.Size = new System.Drawing.Size(829, 26);
            this.prgProgressBar.TabIndex = 29;
            // 
            // btnBrowseSave
            // 
            this.btnBrowseSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtSaveDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnDeleteProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProfile.Location = new System.Drawing.Point(441, 284);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(81, 23);
            this.btnDeleteProfile.TabIndex = 33;
            this.btnDeleteProfile.Text = "Delete Profile";
            this.btnDeleteProfile.UseVisualStyleBackColor = true;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // pctrPreviewImage
            // 
            this.pctrPreviewImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrPreviewImage.Location = new System.Drawing.Point(274, 284);
            this.pctrPreviewImage.Name = "pctrPreviewImage";
            this.pctrPreviewImage.Size = new System.Drawing.Size(161, 114);
            this.pctrPreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrPreviewImage.TabIndex = 34;
            this.pctrPreviewImage.TabStop = false;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckAll.Location = new System.Drawing.Point(12, 365);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(92, 23);
            this.btnCheckAll.TabIndex = 35;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUncheckAll.Location = new System.Drawing.Point(172, 365);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(92, 23);
            this.btnUncheckAll.TabIndex = 36;
            this.btnUncheckAll.Text = "Uncheck All";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // chklstFiles
            // 
            this.chklstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chklstFiles.FormattingEnabled = true;
            this.chklstFiles.Location = new System.Drawing.Point(12, 130);
            this.chklstFiles.Name = "chklstFiles";
            this.chklstFiles.Size = new System.Drawing.Size(252, 229);
            this.chklstFiles.TabIndex = 37;
            this.chklstFiles.SelectedValueChanged += new System.EventHandler(this.chklstFiles_SelectedIndexChanged);
            this.chklstFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.chklstFiles_DragDrop);
            this.chklstFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.chklstFiles_DragEnter);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(634, 336);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "GoGo";
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(441, 374);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(82, 23);
            this.btnExport.TabIndex = 38;
            this.btnExport.Text = "Export Profiles";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(441, 345);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(81, 23);
            this.btnImport.TabIndex = 39;
            this.btnImport.Text = "Import Profiles";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 441);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.chklstFiles);
            this.Controls.Add(this.btnUncheckAll);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.pctrPreviewImage);
            this.Controls.Add(this.btnDeleteProfile);
            this.Controls.Add(this.chkDefaultSave);
            this.Controls.Add(this.btnBrowseSave);
            this.Controls.Add(this.txtSaveDirectory);
            this.Controls.Add(this.prgProgressBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseSelect);
            this.Controls.Add(this.txtSelectDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProfile);
            this.MinimumSize = new System.Drawing.Size(869, 479);
            this.Name = "Form1";
            this.Text = "Photo Bomber XL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrPreviewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProfile;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar prgProgressBar;
        private System.Windows.Forms.Button btnBrowseSave;
        private System.Windows.Forms.TextBox txtSaveDirectory;
        private System.Windows.Forms.CheckBox chkDefaultSave;
        private System.Windows.Forms.ComboBox cmbFileType;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.ComboBox cmbExifMaintained;
        private System.Windows.Forms.PictureBox pctrPreviewImage;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.CheckedListBox chklstFiles;
        private System.Windows.Forms.ComboBox cmbFileSize;
        private System.Windows.Forms.Button btnCancelProfile;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
    }
}

