using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsRoverPhotoBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLoadDatesFile_Click(object sender, EventArgs e)
        {
            PopulateDates();
        }

        private void cmbImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplayImage();
        }

        private void txtDatesFile_Click(object sender, EventArgs e)
        {
            GetDatesFile();
        }

        private void PopulateDates()
        {
            string fileName = txtDatesFile.Text.Trim();
            List<string> dates = File.ReadAllLines(fileName).ToList();

            DateTime tempDate;
            int numInvalidDates = dates.RemoveAll(item => !DateTime.TryParse(item, out tempDate));
            lblInvalidDates.Visible = (numInvalidDates > 0);
            
            cmbDate.DataSource = dates;
        }

        private void UpdateImagesList(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime();
            if (!DateTime.TryParse(cmbDate.SelectedValue.ToString(), out selectedDate))
                return;

            RoverPhotosRetriever photosRetriever = new RoverPhotosRetriever();
            photosRetriever.PhotosUrl = ConfigurationManager.AppSettings.Get("urlRoverPhotos");
            photosRetriever.RoverPlaceholderName = ConfigurationManager.AppSettings.Get("roverPlaceholderKeyword");
            photosRetriever.RoverName = "Curiosity"; //TODO: Replace with user-selected value
            photosRetriever.ApiKeyAttrName = ConfigurationManager.AppSettings.Get("attributeApiKey");
            photosRetriever.ApiKey = ConfigurationManager.AppSettings.Get("apiKey");
            photosRetriever.EarthDateAttrName = ConfigurationManager.AppSettings.Get("attributeEarthDate");
            photosRetriever.EarthDate = selectedDate;

            cmbImage.DataSource = new BindingSource(photosRetriever.RetrievePhotosList(), null);
            cmbImage.DisplayMember = "Filename";
            cmbImage.ValueMember = "Url";
        }

        private void UpdateDisplayImage()
        {
            RoverPhoto selectedImage = (RoverPhoto) cmbImage.SelectedItem;
            picBox.Load(selectedImage.Url);
            picBox.Tag = selectedImage.Url;
            picBox.Refresh();
        }

        private void LoadImageInBrowser(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start((string) picBox.Tag);
        }
        
        private void GetDatesFile()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDatesFile.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
