using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Facebook
{
    public partial class FormFacebook : Form
    {
        private readonly FacebookManager m_FacebookManager;

        public FormFacebook()
        {
            InitializeComponent();
            m_FacebookManager = new FacebookManager();

        }

        private void m_LoginLogoutBtn_Click(object sender, EventArgs e)
        {
            if (m_LoginLogoutBtn.Text == "Login")
            {
                m_FacebookManager.Login();
                m_LoginLogoutBtn.Text = "Logout";
                fetcUserInfo();
               
            }
            else
            {
                disconnect();
            }
        }

        private void disconnect()
        {
            m_FacebookManager.Logout();
            cleanUI();
        }

        private void cleanUI()
        //Clean app
        {
            m_ProfilePicMain.Visible = false;
            m_LoginLogoutBtn.Text = "Login";
            labelProfileName.Text = "ProfileName";
            labelBirthday.Text = "Birthday";
            labelGender.Text = "Gender";
        }

        private void fetcUserInfo()
        {
            fetcPerofileInfo();
            fetchUserAlbums();
            fetchUserCheckin();
            FetchUserFriends();
            fetchPosts();
        }
        private void fetcPerofileInfo()
        {//fill all data we fetch with permissions
            try
            {
               
                labelProfileName.Text = m_FacebookManager.m_LoggedInUser.Name.ToString();
                m_ProfilePicMain.LoadAsync(m_FacebookManager.m_LoggedInUser.PictureNormalURL);
                labelBirthday.Text = m_FacebookManager.m_LoggedInUser.Birthday.ToString();
                labelGender.Text = m_FacebookManager.m_LoggedInUser.Gender.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchUserAlbums()
        {
            //פונקציה שמוספיה אלבומים לליסט בוקס

            foreach (Album album in m_FacebookManager.m_LoggedInUser.Albums)
            {
                listBox1.Items.Add(album.Name);
                
            }
        }

        private void fetchUserCheckin()
        {
            //פונקציה שמוספיה צק אינס לליסט בוקס
            foreach (Checkin check in m_FacebookManager.m_LoggedInUser.Checkins)
            {
                listBox2.Items.Add(check.Place.Name);
            }
        }
        private List<string> FetchUserFriends()
        {// פונקציה שעוברת על רשימת החברים ומוסיפה לרשימה ולליסט בוקס
            List<string> friendsList = new List<string>();
            foreach (User friend in m_FacebookManager.m_LoggedInUser.Friends)
            {
                friendsList.Add(friend.Name);
                listBox2.Items.Add(friend.Friends);

            }

            return friendsList;
        }
    
        private void fetchPosts()
        {//פונקציה שעוברת על כל הפוסטים מוביפה לרשימה ולליסט בוקס 
            int counter = 0;
            List<string> postList = new List<string>();
            foreach (Post user in m_FacebookManager.m_LoggedInUser.Posts)
            {
                listBox3.Items.Add(user.CreatedTime);
                listBox3.Items.Add(user.Comments);
                postList.Add(user.Caption);
                counter++;
            }
            listBox3.Items.Add(counter);
        }


        private void sortByGender()
        {//רשימה של ההרשאות שאפשר לשחק איתם
            m_FacebookManager.m_LoggedInUser.Email.ToString();
            m_FacebookManager.m_LoggedInUser.Gender.ToString();
            m_FacebookManager.m_LoggedInUser.About.ToString();
            m_FacebookManager.m_LoggedInUser.Albums.ToString();
            m_FacebookManager.m_LoggedInUser.Birthday.ToString();
            m_FacebookManager.m_LoggedInUser.Checkins.ToString();
            m_FacebookManager.m_LoggedInUser.FavofriteTeams.ToString();
            m_FacebookManager.m_LoggedInUser.Groups.ToString();
            m_FacebookManager.m_LoggedInUser.Hometown.ToString();
            m_FacebookManager.m_LoggedInUser.Posts.ToString();
            m_FacebookManager.m_LoggedInUser.LikedPages.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        
      
    }
}
