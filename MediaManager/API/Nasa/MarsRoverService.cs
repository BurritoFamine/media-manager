using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MediaManager.API.Models.MarsRover;

namespace MediaManager.API.Nasa
{
    public class MarsRoverService : BaseNasaService
    {
        private const string _roverUri = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?";
        private string _baseUri = _roverUri + "api_key=" + ApiKey;

        public void DownloadMarsPhotosByDate(List<DateTime> dates)
        {
            using (WebClient client = new WebClient())
            {
                foreach (var date in dates)
                {
                    var folder = OutputNasaFolder + date.ToString("yyyy-MM-dd");
                    System.IO.Directory.CreateDirectory(folder);
                    int page = 1;

                    Rootobject rootObject;
                    do
                    {
                        string uri = _baseUri;
                        uri += "&earth_date=" + date.ToString("yyyy-MM-dd");
                        uri += "&page=" + page;

                        string json = client.DownloadString(uri);
                        rootObject = JsonConvert.DeserializeObject<Rootobject>(json);

                        int counter = 0;
                        foreach (var photo in rootObject.photos)
                        {
                            string fileName = photo.id + ".JPG";
                            client.DownloadFile(photo.img_src, folder + "/" + fileName);
                            Logger.Instance.Log(photo.img_src);
                            counter++;
                        }

                        page++;
                    } while (rootObject.photos.Count() > 0);
                }
            }
        }
    }
}
