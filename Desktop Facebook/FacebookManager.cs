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
            m_LoginResult = FacebookService.Login("396203801511633",
              "user_birthday",
              "user_hometown",
              "user_location",
              "user_likes",
              "user_events",
              "user_photos",
              "user_videos",
              "user_friends",
              "user_status",
              "user_tagged_places",
              "user_posts",
              "user_gender",
              "user_link",
              "user_age_range",
              "email",
              "user_managed_groups",
              "pages_show_list",
              "public_profile");

            m_LoggedInUser = m_LoginResult.LoggedInUser;
        }
        public void Logout()
        {
            FacebookService.Logout(null);
            m_LoggedInUser = null;
            m_LoginResult = null;
        }


    }
}
