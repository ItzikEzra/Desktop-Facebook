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

        public User m_LoggedInUser { get; set; }

        public LoginResult m_LoginResult { get; set; }

        public void Login()
        {
            m_LoginResult = FacebookService.Login(
                "2842375502752590",
                "public_profile");

            this.m_LoggedInUser = this.m_LoginResult.LoggedInUser;
        }
        public void Logout()
        {
            FacebookService.Logout(null);
            this.m_LoggedInUser = null;
            this.m_LoginResult = null;
        }

      internal List<string> FetchUserFriends()
        {
            List<string> friendsList = new List<string>();
            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                friendsList.Add(friend.Name);
            }

            return friendsList;
        }
   
     

    }
}
