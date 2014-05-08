﻿using System;
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
            cmbFileType.DataSource = Enum.GetValues(typeof(Profile.fileTypes));
            lstProfileList.DisplayMember = "name";
        }

        // this populates the list box with profiles from the txt file
        public void loadProfilesFromFile()
        {
            MessageBox.Show(Application.UserAppDataPath + "\\appdata.txt");
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
            String[] profileData =  data.Split('+');
            for (int i = 0; i < profileData.Length - 1; i+=8)
            {
                Profile.fileTypes fileType = (Profile.fileTypes)Enum.Parse(typeof(Profile.fileTypes), profileData[i + 3]);
                Profile p = new Profile(profileData[i + 0], Convert.ToInt32(profileData[i + 1]), Convert.ToInt32(profileData[i + 2]), fileType, Convert.ToInt32(profileData[i + 4]), Convert.ToInt32(profileData[i + 5]), Convert.ToInt32(profileData[i + 6]), true);
                lstProfileList.Items.Add(p);
            }
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
                profileData[i] += ((Profile)lstProfileList.Items[i]).name + "+";
                profileData[i] += ((Profile)lstProfileList.Items[i]).heightInPixels + "+";
                profileData[i] += ((Profile)lstProfileList.Items[i]).widthInPixels + "+";
                profileData[i] += ((Profile)lstProfileList.Items[i]).fileType + "+";
                profileData[i] += ((Profile)lstProfileList.Items[i]).fileSize + "+";
                profileData[i] += ((Profile)lstProfileList.Items[i]).aspectHeight + "+";
                profileData[i] += ((Profile)lstProfileList.Items[i]).aspectWidth + "+";
                profileData[i] += ((Profile)lstProfileList.Items[i]).isExifMaintained + "+";
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
            Profile.fileTypes fileType = (Profile.fileTypes)Enum.Parse(typeof(Profile.fileTypes), cmbFileType.Text);
            Profile p = new Profile(txtProfileName.Text, Convert.ToInt32(txtHeight.Text), Convert.ToInt32(txtWidth.Text), fileType, Convert.ToInt32(txtFileSize.Text), Convert.ToInt32(txtAspectHeight.Text), Convert.ToInt32(txtAspectWidth.Text), true);
            lstProfileList.Items.Add(p);
            
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
            txtProfileName.Text = ((Profile)lstProfileList.SelectedItem).name;
            txtHeight.Text = ((Profile)lstProfileList.SelectedItem).heightInPixels.ToString();
            txtWidth.Text = ((Profile)lstProfileList.SelectedItem).widthInPixels.ToString();
            cmbFileType.Text = ((Profile)lstProfileList.SelectedItem).fileType.ToString();
            txtFileSize.Text = ((Profile)lstProfileList.SelectedItem).fileSize.ToString();
            txtAspectHeight.Text = ((Profile)lstProfileList.SelectedItem).aspectHeight.ToString();
            txtAspectWidth.Text = ((Profile)lstProfileList.SelectedItem).aspectWidth.ToString();
            txtExifMaintained.Text = ((Profile)lstProfileList.SelectedItem).isExifMaintained.ToString();
        }

        private void btnBrowseSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
