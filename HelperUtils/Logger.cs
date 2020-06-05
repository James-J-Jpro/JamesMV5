using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace JamesScioMVC5.HelperUtils
{
    public class Logger
    {
        public static void Log(string LogMessage)
        {
            var v = AppDomain.CurrentDomain.BaseDirectory;
            File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "/Log/Log.txt", "\n\n"+LogMessage);
        }
    }
}