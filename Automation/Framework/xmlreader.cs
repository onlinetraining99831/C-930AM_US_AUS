using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Automation.Framework
{
    public class xmlreader
    {
        public static Dictionary<string,string> getCredentials(string filename, string usertype)
        {
            Dictionary<string, string> logindata = new Dictionary<string, string>();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(constants.projectpath+"//Credentials//"+filename+".xml");

            foreach (XmlNode node in xmldoc.DocumentElement)  // root element of xml file
            {
                if(node.Attributes["type"].InnerText.Equals(usertype))
                {
                    foreach(XmlNode child in node.ChildNodes)
                    {
                        if(child.Name.Equals("username"))
                        {
                            logindata.Add("username", child.InnerText);
                           // Console.WriteLine("username is "+child.InnerText);
                        }
                        if (child.Name.Equals("password"))
                        {
                            logindata.Add("password", child.InnerText);
                           // Console.WriteLine("password is " + child.InnerText);
                        }
                    }
                    break;
                }
            }
            return logindata;
       }

    }
}
