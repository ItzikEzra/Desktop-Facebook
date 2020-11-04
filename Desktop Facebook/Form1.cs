﻿using System;
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
               //get detailes 
                this.fetchUserInfo();
            }
            else
            {
                this.m_FacebookManager.Logout();
               //clean the screen
                this.m_LoginLogoutBtn.Text = "Login";
            }
        }

    
        private void fetchUserInfo()
        {
            try
            {
                this.m_ProfilePicMain.LoadAsync(this.m_FacebookManager.LoggedInUser.PictureNormalURL);
                this.labelProfileName.Text = this.m_FacebookManager.LoggedInUser.Name.ToString();
                //this.labelBirthday.Text = this.m_FacebookManager.LoggedInUser.Birthday.ToString();
                //this.labelGender.Text = this.m_FacebookManager.FetchUserGender();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #region
        private void labelProfileName_Click(object sender, EventArgs e)
        {
        }


        private void FormFacebook_Load(object sender, EventArgs e)
        {

        }

        private void labelProfileName_Click_1(object sender, EventArgs e)
        {

        }
        private void m_ProfilePicMain_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}