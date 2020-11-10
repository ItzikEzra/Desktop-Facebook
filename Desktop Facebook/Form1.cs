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
        private FacebookManager m_FacebookManager;

        public FormFacebook()
        {
            InitializeComponent();
            this.m_FacebookManager = new FacebookManager();

        }

        private void m_LoginLogoutBtn_Click(object sender, EventArgs e)
        {
            if (this.m_LoginLogoutBtn.Text == "Login")
            {
                this.m_FacebookManager.Login();
                this.m_LoginLogoutBtn.Text = "Logout";
                this.fetchUserInfo();
            }
            else
            {
                this.m_FacebookManager.Logout();
                cleanUi();
                this.m_LoginLogoutBtn.Text = "Login";
            }
        }

        private void cleanUi()
        {
            this.labelProfileName.Text = "ProfileName";
            //Clean app
        }

        private void fetchUserInfo()
        {//fill all data we fetch with permissions
            try
            {
                this.m_ProfilePicMain.LoadAsync(this.m_FacebookManager.m_LoggedInUser.PictureNormalURL);
                this.labelProfileName.Text = this.m_FacebookManager.m_LoggedInUser.Name.ToString();
                //this.labelBirthday.Text = this.m_FacebookManager.LoggedInUser.Birthday.ToString();
                //this.labelGender.Text = this.m_FacebookManager.LoggedInUser.Gender();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private List<User> fetchUserFriends()
        //{
        //   return(List<User> fetchUserFriends =
        //        m_FacebookManager.LoggedInUser.FriendLists());
        //}
        private void sortByGender()
        {
            //  List<string> friends = m_FacebookManager.LoggedInUser.Friends.ToString();
            List<string> friends = this.m_FacebookManager.FetchUserFriends();
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
       
    }
}
