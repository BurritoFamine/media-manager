using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager.API
{
    /// <summary>
    /// Base class for calling API to get media
    /// </summary>
    public abstract class BaseService
    {
        public BaseService()
        {
            System.IO.Directory.CreateDirectory(OutputFolder);
        }

        public static string OutputFolder = "../../../Output/";

    }
}
