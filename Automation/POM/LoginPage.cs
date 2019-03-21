using Automation.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.POM
{
   public class LoginPage 
    {
        IWebDriver driver;

        Dictionary<string, string> credentials;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By usernametxt = By.Id("ctl00_MainContent_username");
        By passwordtxt = By.Name("ctl00$MainContent$password");
        By loginbtn = By.Id("ctl00_MainContent_login_button");

        //********************************************************************

        //public void login(string uname, string pwd)
        //{
        //    driver.FindElement(usernametxt).SendKeys(uname);
        //    driver.FindElement(passwordtxt).SendKeys(pwd);
        //    driver.FindElement(loginbtn).Click();
        //}

        public void login(string uname, string pwd)
        {
            browserutils.sendkeys(drivermanager.getdriver().FindElement(usernametxt), uname);
            browserutils.sendkeys(drivermanager.getdriver().FindElement(passwordtxt), pwd);
            browserutils.clickOn(drivermanager.getdriver().FindElement(loginbtn));
        }


        public void loginAs(string usertype)
        {
            credentials= xmlreader.getCredentials("login", "admin");
            login(credentials["username"], credentials["password"]);
        }
    }
}
