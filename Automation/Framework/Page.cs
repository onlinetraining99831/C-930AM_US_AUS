using Automation.POM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework
{
    public class Page
    {
        public static LoginPage loginpage = new LoginPage(drivermanager.getdriver());
        public static HomePage homepage = new HomePage(drivermanager.getdriver());
    }
}
