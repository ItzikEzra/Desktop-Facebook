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
        public Fetcher m_fetcher = new Fetcher();
        private List<string> m_CheckInsList, m_FriendsList, m_PostsList, m_AlbumsList = new List<string>();

        public FormFacebook()
        {
            InitializeComponent();
            m_FacebookManager = FacebookManager.Instance;
            m_fetcher = new Fetcher();

        }

        private void disconnect()
        {
            m_FacebookManager.Logout();
            cleanUI();
        }

        private void fillInfo()
        {
           foreach(string album in m_AlbumsList)
            {
                listBox1.Items.Add(album);
            }
            foreach (string checkIn in m_CheckInsList)
            {
                listBox2.Items.Add(checkIn);
            }
            foreach (string friend in m_FriendsList)
            {
                listBox3.Items.Add(friend);
            }
            foreach (string post in m_PostsList)
            {
                //listBox4.Items.Add(post);
            }
        }

        private void cleanUI()
        {
            m_ProfilePicMain.Visible = false;
            m_LoginLogoutBtn.Text = "Login";
            labelProfileName.Text = "ProfileName";
            labelBirthday.Text = "Birthday";
            labelGender.Text = "Gender";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
        }

        private void loginStarter()
        {

            fetcPerofileInfo();
            m_AlbumsList = m_fetcher.fetchUserAlbums();
            m_CheckInsList = m_fetcher.fetchUserCheckin();
            m_FriendsList = m_fetcher.FetchUserFriends();
            m_PostsList = m_fetcher.fetchPosts();
            fillInfo();
        }

        private void m_BestPhotoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_FacebookManager.m_LoggedInUser != null)
                {
                    BestTimePostHandel();

                    BestTimePhotoHandel();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BestTimePostHandel()
        {
            List<string> posts = new List<string>();
            int timeForPosts = BestTimeToUpload.sr_Best.FindBestTimeToUploadAPost(posts);
            label6.Text += timeForPosts.ToString();
        }

        private void BestTimePhotoHandel()
        {
            List<string> pictures = new List<string>();
            int timeForPhotos = BestTimeToUpload.sr_Best.FindBestTimeToUploadAPicture(pictures);
            m_BestTimeLabel.Text += timeForPhotos.ToString();

            if (pictures.Count > 0)
            {
                m_BestTImePic.LoadAsync(pictures[0]);
            }
            else
            {
                m_BestTimeLabel.Text = "No photos, so there is your profile picture";
                m_BestTImePic.LoadAsync(m_FacebookManager.m_LoggedInUser.PictureNormalURL);
            }
        }

        private void fetcPerofileInfo()
        {//fill all data we fetch with permissions
            try
            {
                labelProfileName.Text = m_fetcher.fetchUserName();
                m_ProfilePicMain.LoadAsync(m_FacebookManager.m_LoggedInUser.PictureNormalURL);
                labelBirthday.Text = m_fetcher.fetchUserBirthday();
                labelGender.Text = m_fetcher.fetchUseGender();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void loginLogoutBtn_Click(object sender, EventArgs e)
        {

            if (m_LoginLogoutBtn.Text == "Login")
            {
                m_FacebookManager.Login();
                m_LoginLogoutBtn.Text = "Logout";
                loginStarter();

            }
            else
            {
                disconnect();
            }
        }
    }
}
