using Automation.Framework;
using Automation.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Tests
{
    public class smoketest
    {
        [Test]
        public void Verifycreationofuserintheapplication()
        {
            //drivermanager.initiatebrowser(constants.browser);
            //browserutils browserutils = new browserutils(drivermanager.getdriver());
            //browserutils.openapplication(constants.url);
            //Dictionary<string, string> credentials = xmlreader.getCredentials("login", "admin");
            //LoginPage loginpage = new LoginPage(drivermanager.getdriver());
            //loginpage.login(credentials["username"], credentials["password"]);

            browserutils.openapplication(constants.url);
            Page.loginpage.loginAs("admin");
            Page.homepage.logout();
         }

    }
}
