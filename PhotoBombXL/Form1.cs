using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//      this is where the profiles are saved on my comp in a txt file
//      C:\Users\Garrett Kliewer\AppData\Roaming\Microsoft\PhotoBombXL\1.0.0.0

namespace PhotoBombXL
{
    public partial class Form1 : Form
    {
        // these handle the file browsing
        private FolderBrowserDialog folderBrowserDialogInputDestination;
        private FolderBrowserDialog folderBrowserDialogOutputDestination;

        public Form1()
        {
            InitializeComponent();

            // load the profiles into the list box from the file
            loadProfilesFromFile();

            // set the combo box options
            cmbFileType.DataSource = Enum.GetValues(typeof(Profile.fileTypes));
            cmbExifMaintained.DataSource = Enum.GetValues(typeof(Profile.exifMaintained));

            // this makes the profile list box use the name of the profile as its text
            lstProfile.DisplayMember = "name";

            // init the folder browser dialog
            folderBrowserDialogInputDestination = new FolderBrowserDialog();
            folderBrowserDialogInputDestination.Description = "Select where your images to be converted are";
            folderBrowserDialogInputDestination.ShowNewFolderButton = false;
            folderBrowserDialogInputDestination.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); //use this to set the default folder
            txtSelectDirectory.Text = folderBrowserDialogInputDestination.SelectedPath;
            populateListboxWithImageFiles();

            folderBrowserDialogOutputDestination = new FolderBrowserDialog();
            folderBrowserDialogOutputDestination.Description = "Select where to save your converted images";
            folderBrowserDialogOutputDestination.ShowNewFolderButton = true;
            //folderBrowserDialogOutputDestination.SelectedPath = use this to set the default folder, i don't know what to put here
            //txtSaveDirectory.Text = folderBrowserDialogOutputDestination.SelectedPath;
        }

        // this populates the list box with profiles from the txt file
        private void loadProfilesFromFile()
        {
            if(!File.Exists(Application.UserAppDataPath + "\\appdata.txt"))
            {
                return;
            }
            String data;
            try
            {
                data = System.IO.File.ReadAllText(Application.UserAppDataPath + "\\appdata.txt");
            }
            catch (IOException e)
            {
                MessageBox.Show("An error occurred loading the profiles: " + e.ToString());
                return;
            }
            String[] profileData =  data.Split('\v');
            for (int i = 0; i < profileData.Length - 1; i+=8)
            {
                Profile.fileTypes fileType = (Profile.fileTypes)Enum.Parse(typeof(Profile.fileTypes), profileData[i + 3]);
                Profile p = new Profile(profileData[i + 0], Convert.ToInt32(profileData[i + 1]), Convert.ToInt32(profileData[i + 2]), fileType, Convert.ToInt32(profileData[i + 4]), Convert.ToInt32(profileData[i + 5]), Convert.ToInt32(profileData[i + 6]), true);
                lstProfile.Items.Add(p);
            }
        }

        private void saveProfilesToFile()
        {
            // make sure we have at least one profile to save
            int numOfProfiles = lstProfile.Items.Count;
            if(numOfProfiles < 1)
            {
                MessageBox.Show("No profiles found");
                return;
            }

            // this string will be written to a txt file
            string[] profileData = new string[numOfProfiles];

            // getting profiles from list
            for (int i = 0; i < numOfProfiles; i++)
            {
                profileData[i] += ((Profile)lstProfile.Items[i]).name + "\v";
                profileData[i] += ((Profile)lstProfile.Items[i]).heightInPixels + "\v";
                profileData[i] += ((Profile)lstProfile.Items[i]).widthInPixels + "\v";
                profileData[i] += ((Profile)lstProfile.Items[i]).fileType + "\v";
                profileData[i] += ((Profile)lstProfile.Items[i]).fileSize + "\v";
                profileData[i] += ((Profile)lstProfile.Items[i]).aspectHeight + "\v";
                profileData[i] += ((Profile)lstProfile.Items[i]).aspectWidth + "\v";
                profileData[i] += ((Profile)lstProfile.Items[i]).isExifMaintained + "\v";
            }

            try
            {
                // WriteAllLines creates a file, writes a collection of strings to the file,
                // and then closes the file.
                System.IO.File.WriteAllLines(Application.UserAppDataPath + "\\appdata.txt", profileData);
            }
            catch (IOException e)
            {
                MessageBox.Show("An error occurred saving the profiles: " + e.ToString());
            }
        }

        private void populateListboxWithImageFiles()
        {
            // clear the list box
            chklstFiles.Items.Clear();
            // get the files
            string[] files = Directory.GetFiles(folderBrowserDialogInputDestination.SelectedPath);

            // poputlate the list box with files
            foreach (string file in files)
            {
                // display only image files
                if (string.Equals(Path.GetExtension(file), ".jpg", StringComparison.CurrentCultureIgnoreCase) ||
                    string.Equals(Path.GetExtension(file), ".jpeg", StringComparison.CurrentCultureIgnoreCase) ||
                    string.Equals(Path.GetExtension(file), ".raw", StringComparison.CurrentCultureIgnoreCase) ||
                    string.Equals(Path.GetExtension(file), ".gif", StringComparison.CurrentCultureIgnoreCase) ||
                    string.Equals(Path.GetExtension(file), ".png", StringComparison.CurrentCultureIgnoreCase) ||
                    string.Equals(Path.GetExtension(file), ".bmp", StringComparison.CurrentCultureIgnoreCase) ||
                    string.Equals(Path.GetExtension(file), ".tiff", StringComparison.CurrentCultureIgnoreCase))

                {
                    chklstFiles.Items.Add(Path.GetFileName(file));
                }
            }
        }

        /***************************************************
         *      Handle closing of the app                  *
         * ************************************************/
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            saveProfilesToFile();
        }

        //   *************
        //   * GUI LOGIC *
        //   *************

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            Profile.fileTypes fileType = (Profile.fileTypes)Enum.Parse(typeof(Profile.fileTypes), cmbFileType.Text);
            Profile.exifMaintained exifMaintained = (Profile.exifMaintained)Enum.Parse(typeof(Profile.exifMaintained), cmbExifMaintained.Text);

            bool isExifMaintained = exifMaintained == Profile.exifMaintained.Yes ? true : false;

            Profile p = new Profile(txtProfileName.Text, Convert.ToInt32(txtHeight.Text), Convert.ToInt32(txtWidth.Text), fileType, Convert.ToInt32(txtFileSize.Text), Convert.ToInt32(txtAspectHeight.Text), Convert.ToInt32(txtAspectWidth.Text), isExifMaintained);
            lstProfile.Items.Add(p);
        }

        private void chkDefaultSave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDefaultSave.Checked == true)
            {
                btnBrowseSave.Enabled = false;
                txtSaveDirectory.Enabled = false;
            }
            else
            {
                btnBrowseSave.Enabled = true;
                txtSaveDirectory.Enabled = true;
            }
        }

        private void lstProfileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProfile.SelectedItem == null)
            {
                return;
            }
            txtProfileName.Text = ((Profile)lstProfile.SelectedItem).name;
            txtHeight.Text = ((Profile)lstProfile.SelectedItem).heightInPixels.ToString();
            txtWidth.Text = ((Profile)lstProfile.SelectedItem).widthInPixels.ToString();
            cmbFileType.Text = ((Profile)lstProfile.SelectedItem).fileType.ToString();
            txtFileSize.Text = ((Profile)lstProfile.SelectedItem).fileSize.ToString();
            txtAspectHeight.Text = ((Profile)lstProfile.SelectedItem).aspectHeight.ToString();
            txtAspectWidth.Text = ((Profile)lstProfile.SelectedItem).aspectWidth.ToString();
            cmbExifMaintained.Text = ((Profile)lstProfile.SelectedItem).isExifMaintained == true ? "Yes" : "No";
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            lstProfile.Items.Remove((Profile)lstProfile.SelectedItem);
        }

        private void btnBrowseSelect_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogInputDestination.ShowDialog() == DialogResult.OK)
            {
                // sets the text box with the path
                txtSelectDirectory.Text = folderBrowserDialogInputDestination.SelectedPath;

                populateListboxWithImageFiles();
            }
        }

        private void btnBrowseSave_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogOutputDestination.ShowDialog() == DialogResult.OK)
            {
                txtSaveDirectory.Text = folderBrowserDialogOutputDestination.SelectedPath;
            }
        }

        private void chklstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pctrPreviewImage.Image = Image.FromFile(txtSelectDirectory.Text + "\\" + chklstFiles.SelectedItem);
            }
            catch (Exception exception)
            {
                // sometimes the path gets messed up but it's not really necessary to handle
            }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstFiles.Items.Count; i++)
                chklstFiles.SetItemChecked(i, true);
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstFiles.Items.Count; i++)
                chklstFiles.SetItemChecked(i, false);
        }
    }
}