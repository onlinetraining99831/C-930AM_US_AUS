using Automation.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.POM
{
    public class HomePage 
    {
        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_logout")]
        IWebElement logoutlnk;

        //IWebElement logoutlink = driver.FindElement(By.Id("ctl00_logout"));
        public void logout()
        {
            browserutils.clickOn(logoutlnk);
        }
        
    }
}
