using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoBombXL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadProfilesFromFile();
        }

        public void loadProfilesFromFile()
        {
            String profileData = System.IO.File.ReadAllText(Application.UserAppDataPath + "\\appdata.txt");
            MessageBox.Show(profileData);
        }

        public void saveProfilesToFile()
        {
            // make sure we have at least one profile to save
            int numOfProfiles = lstProfileList.Items.Count;
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
                profileData[i] += ((Profile)lstProfileList.Items[i]).name + " ";
                profileData[i] += ((Profile)lstProfileList.Items[i]).heightInPixels + " ";
                profileData[i] += ((Profile)lstProfileList.Items[i]).widthInPixels + " ";
                profileData[i] += ((Profile)lstProfileList.Items[i]).fileType + " ";
                profileData[i] += ((Profile)lstProfileList.Items[i]).fileSize + " ";
                profileData[i] += ((Profile)lstProfileList.Items[i]).aspectHeight + " ";
                profileData[i] += ((Profile)lstProfileList.Items[i]).aspectWidth + " ";
                profileData[i] += ((Profile)lstProfileList.Items[i]).isExifMaintained + " ";
            }

            try
            {
                // WriteAllLines creates a file, writes a collection of strings to the file,
                // and then closes the file.
                System.IO.File.WriteAllLines(Application.UserAppDataPath + "\\appdata.txt", profileData);
            }
            catch (IOException e)
            {
                // Inform the user that an error occurred.
                MessageBox.Show("An error occurred while attempting to show the application. The error is:" + e.ToString());
            }
        }


        //   *************
        //   * GUI LOGIC *
        //   *************
        private void button1_Click(object sender, EventArgs e)
        {
            saveProfilesToFile();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadProfilesFromFile();
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            Profile p = new Profile(txtProfileName.Text, Convert.ToInt32(txtHeight.Text), Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtFileType.Text), Convert.ToInt32(txtFileSize.Text), Convert.ToInt32(txtAspectHeight.Text), Convert.ToInt32(txtAspectWidth.Text), true);
            lstProfileList.Items.Add(p);
        }
    }
}
