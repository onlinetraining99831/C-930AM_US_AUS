using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework
{
    public class drivermanager 
    {
        private static IWebDriver driver;

        public static IWebDriver getdriver()
        {
            if(driver==null)
            {
                initiatebrowser(ConfigurationManager.AppSettings["browser"]);
                return driver;
            }

            return driver;
        }
 
        public static void initiatebrowser(string typeofbrowser)
        {
            switch (typeofbrowser)
            {
                case "chrome":
                    driver = new ChromeDriver(constants.pathtodriverfiles);
                    driver.Manage().Window.Maximize();
                    break;

                case "firefox":
                    break;
                  
                default:
                    throw new Exception(typeofbrowser + " is not supported Yet.");
                    break;
            }
        }

    }
}
