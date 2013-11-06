using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleBrowser;

namespace Netling.Core
{
    public class SimpleBrowser
    {
        public static Browser Instance { get; private set; }

        public static void LoginEpiserverWebForms(string loginUrl, string username, string password)
        {
            var browser = new Browser();
            browser.Navigate(loginUrl);

            browser.Find("FullRegion_LoginControl_UserName").Value = username;
            browser.Find("FullRegion_LoginControl_Password").Value = password;
            browser.Find("FullRegion_LoginControl_Button1").Click();
            Instance = browser;
        }
    }
}
