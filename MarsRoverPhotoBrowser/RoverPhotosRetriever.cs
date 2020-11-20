using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;

namespace MarsRoverPhotoBrowser
{
    class RoverPhotosRetriever
    {
        public RoverPhotosRetriever()
        { }

        public string PhotosUrl { private get; set; }
        public string RoverPlaceholderName { private get; set; }
        public string RoverName { private get; set; }
        public string ApiKeyAttrName { private get; set; }
        public string ApiKey { private get; set; }
        public string EarthDateAttrName { private get; set; }
        public DateTime EarthDate { private get; set; }

        public List<RoverPhoto> RetrievePhotosList()
        {
            List<RoverPhoto> photosList = new List<RoverPhoto>();
            
            string jsonResult = GetJsonResult();

            if (jsonResult != String.Empty)
            {
                using (JsonDocument document = JsonDocument.Parse(jsonResult))
                {
                    foreach (JsonElement element in document.RootElement.GetProperty("photos").EnumerateArray())
                    {
                        RoverPhoto photo = new RoverPhoto();
                        photo.Url = element.GetProperty("img_src").GetRawText().Replace('"', ' ').Trim();
                        photosList.Add(photo);
                    }
                }
            }

            return photosList;
        }

        private string GetJsonResult()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(GenerateFinalUrl());
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader streamReader = new StreamReader(response.GetResponseStream());

                return streamReader.ReadToEnd();
            }
            catch
            {
                return String.Empty;
            }
        }

        private string GenerateFinalUrl()
        {
            StringBuilder sbImageUrl = new StringBuilder(this.PhotosUrl);
            sbImageUrl.Replace(this.RoverPlaceholderName, this.RoverName);
            sbImageUrl.Append("?" + this.ApiKeyAttrName + "=" + this.ApiKey);
            sbImageUrl.Append("&" + this.EarthDateAttrName + "=" + this.EarthDate.Year.ToString() + "-" + this.EarthDate.Month.ToString() + "-" + this.EarthDate.Day.ToString());

            return sbImageUrl.ToString();
        }
    }
}
