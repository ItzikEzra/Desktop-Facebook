using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
namespace Desktop_Facebook
{
    public class FacebookManager
    {
        public FacebookManager()
        {

        }

        public User LoggedInUser { get; set; }

        public LoginResult LoginResult { get; set; }

        public void Login()
        {
            LoginResult = FacebookService.Login(
                "2842375502752590",
                "public_profile");

            this.LoggedInUser = this.LoginResult.LoggedInUser;
        }
        public void Logout()
        {
            FacebookService.Logout(null);
            this.LoggedInUser = null;
            this.LoginResult = null;
        }

        public void Connect()
        {
            this.LoggedInUser = LoginResult.LoggedInUser;
        }
   
     

    }
}
