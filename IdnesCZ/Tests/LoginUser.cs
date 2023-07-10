using IdnesCZ.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdnesCZ.Tests
{
    internal class LoginUser : ElementsAndThreadSleep
    {
        public void UserLoginToSite()
        {
            GoToWebSite("");
            ClickOnIdElement("portalogin-link");
            InputTextToNameElement("email", "");
        }
    }
}
