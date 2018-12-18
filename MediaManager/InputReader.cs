using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    public static class InputReader
    {
        public static List<DateTime> ReadDateFile(string path)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(path);

            var dates = new List<DateTime>();
            string line;
            while ((line = file.ReadLine()) != null)
            {
                try
                {
                    DateTime date = DateTime.Parse(line);
                    dates.Add(date);
                    Logger.Instance.Log(date.ToString());
                }
                catch
                {
                    Logger.Instance.Log(string.Format("Could not format date: {0}", line));
                }
            }

            return dates;
        }

    }
}
