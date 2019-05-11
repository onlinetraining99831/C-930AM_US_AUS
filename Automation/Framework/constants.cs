using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework
{
    public class constants
    {
        public static string projectdllpath = Assembly.GetExecutingAssembly().Location;
        public static string projectpath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(projectdllpath)));
        public static string solpath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(projectdllpath))));
        public static string url = ConfigurationManager.AppSettings.Get("appurl");
        public static string browser = ConfigurationManager.AppSettings.Get("browser");
        public static string pathtodriverfiles = solpath + @"\packages\Selenium.Chrome.WebDriver.74.0.0\driver";
    }
}
