using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Desktop_Facebook
{
    public class Fetcher
    {
        public readonly FacebookManager m_FacebookManager = FacebookManager.Instance;


        public Fetcher()
        {

        }

        public List<string> fetchUserAlbums()
        {
            //פונקציה שמוספיה אלבומים לליסט בוקס
            List<string> albums = new List<string>();
            foreach (Album album in m_FacebookManager.m_LoggedInUser.Albums)
            {
                // listBox1.Items.Add(album.Name);
                albums.Add(album.Name);

            }
            return albums;
        }

        public List<string> fetchUserCheckin()
        {
            //פונקציה שמוספיה צק אינס לליסט בוקס
            List<string> checkIns = new List<string>();
            foreach (Checkin check in m_FacebookManager.m_LoggedInUser.Checkins)
            {
                //  listBox2.Items.Add(check.Place.Name);
                checkIns.Add(check.Place.Name);
            }
            return checkIns;
        }

        public List<string> FetchUserFriends()
        {// פונקציה שעוברת על רשימת החברים ומוסיפה לרשימה ולליסט בוקס
            List<string> friendsList = new List<string>();
            int male = 0, female = 0;
            foreach (User friend in m_FacebookManager.m_LoggedInUser.Friends)
            {
                friendsList.Add(friend.Name);
                //listBox2.Items.Add(friend.Friends);
                if (friend.Gender.ToString() == "male")
                {
                    male++;
                }
                else
                if (friend.Gender.ToString() == "female")
                {
                    female++;
                }

            }

            return friendsList;
        }

        public List<string> fetchPosts()
        {//פונקציה שעוברת על כל הפוסטים מוביפה לרשימה ולליסט בוקס 
            int counter = 0;
            List<string> postList = new List<string>();
            foreach (Post user in m_FacebookManager.m_LoggedInUser.Posts)
            {
                // listBox3.Items.Add(user.CreatedTime);
                //listBox3.Items.Add(user.Comments);
                postList.Add(user.Caption);
                postList.Add(user.CreatedTime.ToString());
                counter++;
            }
            //listBox3.Items.Add(counter);
            return postList;
        }

        public string fetchUserName()
        {
            return (m_FacebookManager.m_LoggedInUser.Name.ToString());

        }

        public string fetchUserBirthday()
        {
            return (m_FacebookManager.m_LoggedInUser.Birthday.ToString());
        }

        public string fetchUseGender()
        {
            return (m_FacebookManager.m_LoggedInUser.Gender.ToString());
        }
    }
}
