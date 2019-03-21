using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework
{
    public class browserutils
    {
        //IWebDriver driver;

        //public browserutils(IWebDriver driver)
        //{
        //    this.driver = driver;
        //}

        //public void openapplication(string url)
        //{
        //    //driver.Navigate().GoToUrl(url);
        //    drivermanager.getdriver().Navigate().GoToUrl(url);
        //}

        public static void openapplication(string url)
        {
          drivermanager.getdriver().Navigate().GoToUrl(url);
        }

        public static void clickOn(IWebElement element)
        {
                element.Click();
        }

        public static void sendkeys(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
            Console.WriteLine("Entered text "+text);
        }







    }
}
