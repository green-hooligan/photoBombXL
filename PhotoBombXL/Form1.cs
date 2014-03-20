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
        }

        // dealing with profiles here
        public void loadProfilesFromFile()
        {

        }

        public void saveProfilesToFile()
        {
            // make sure we have at least one profile to save
            int numOfProfiles = lstProfileList.Items.Count;
            if(numOfProfiles < 1)
            {
                return;
            }

            // this string will be written to a txt file
            string[] profileData = new string[numOfProfiles];

            // getting profiles from list
            for (int i = 0; i < numOfProfiles; i++)
            {
                profileData[i] += ((Profile) lstProfileList.Items[i]).name + " ";
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
                MessageBox.Show("An error occurred while attempting to show the application." +
                                "The error is:" + e.ToString());

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
