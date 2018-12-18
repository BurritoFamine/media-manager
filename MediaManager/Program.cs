using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using MediaManager.API.Nasa;


namespace MediaManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Instance.Log("Begin work");

            var dates = InputReader.ReadDateFile("../../../Input/mars_rover_dates.txt");

            var service = new MarsRoverService();
            service.DownloadMarsPhotosByDate(dates);

            Logger.Instance.Log("Work complete");
        }
    }
}
