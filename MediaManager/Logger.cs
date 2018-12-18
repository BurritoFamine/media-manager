using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MediaManager
{
    /// <summary>
    /// Logging service. Not thread safe.
    /// </summary>
    public class Logger
    {
        private static Logger instance;
        private static string folder = "../../../Logs";
        private static string path =  folder + "/log.txt";

        private Logger()
        {
            System.IO.Directory.CreateDirectory(folder);
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }

        public void Log(string message)
        {
            StreamWriter log;
            if (!File.Exists(path))
            {
                log = new StreamWriter(path);
            }
            else
            {
                log = File.AppendText(path);
            }

            // Write to the file:
            log.WriteLine(DateTime.Now);
            log.WriteLine(message);
            log.WriteLine();
            log.Close();
        }
    }
}
