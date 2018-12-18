using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager.API.Nasa
{
    public abstract class BaseNasaService : BaseService
    {
        public BaseNasaService()
        {
            System.IO.Directory.CreateDirectory(OutputFolder);
        }

        public static string OutputNasaFolder = OutputFolder + "Nasa/";
        public static string ApiKey = "i3FSRWw4A2NxpTCpg2BCvPmPtPrP4deqjtRPMjQD";
        public static string MarsRoverBaseURL = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?api_key=" + ApiKey;

    }
}
