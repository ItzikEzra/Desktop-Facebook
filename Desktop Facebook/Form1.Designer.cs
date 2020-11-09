namespace Desktop_Facebook
{
    partial class FormFacebook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacebook));
            this.m_ProfilePicMain = new System.Windows.Forms.PictureBox();
            this.m_LoginLogoutBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.RememberMe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ProfilePicMain
            // 
            this.m_ProfilePicMain.Location = new System.Drawing.Point(3, 13);
            this.m_ProfilePicMain.Margin = new System.Windows.Forms.Padding(4);
            this.m_ProfilePicMain.Name = "m_ProfilePicMain";
            this.m_ProfilePicMain.Size = new System.Drawing.Size(240, 193);
            this.m_ProfilePicMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_ProfilePicMain.TabIndex = 3;
            this.m_ProfilePicMain.TabStop = false;
            // 
            // m_LoginLogoutBtn
            // 
            this.m_LoginLogoutBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.m_LoginLogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LoginLogoutBtn.Location = new System.Drawing.Point(2, 222);
            this.m_LoginLogoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.m_LoginLogoutBtn.Name = "m_LoginLogoutBtn";
            this.m_LoginLogoutBtn.Size = new System.Drawing.Size(240, 55);
            this.m_LoginLogoutBtn.TabIndex = 4;
            this.m_LoginLogoutBtn.Text = "Login";
            this.m_LoginLogoutBtn.UseVisualStyleBackColor = false;
            this.m_LoginLogoutBtn.Click += new System.EventHandler(this.m_LoginLogoutBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 283);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelProfileName.Location = new System.Drawing.Point(146, 317);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(153, 29);
            this.labelProfileName.TabIndex = 15;
            this.labelProfileName.Text = "ProfileName";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AccessibleName = "labelBirthday";
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelBirthday.Location = new System.Drawing.Point(146, 359);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(106, 29);
            this.labelBirthday.TabIndex = 16;
            this.labelBirthday.Text = "Birthday";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelGender.Location = new System.Drawing.Point(146, 400);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(96, 29);
            this.labelGender.TabIndex = 17;
            this.labelGender.Text = "Gender";
            // 
            // RememberMe
            // 
            this.RememberMe.AutoSize = true;
            this.RememberMe.Location = new System.Drawing.Point(12, 284);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(122, 21);
            this.RememberMe.TabIndex = 18;
            this.RememberMe.Text = "Remember Me";
            this.RememberMe.UseVisualStyleBackColor = true;
            // 
            // FormFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 446);
            this.Controls.Add(this.RememberMe);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.m_LoginLogoutBtn);
            this.Controls.Add(this.labelProfileName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.m_ProfilePicMain);
            this.Name = "FormFacebook";
            this.Text = "FormFaceook";
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox m_ProfilePicMain;
        private System.Windows.Forms.Button m_LoginLogoutBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.CheckBox RememberMe;
    }
}

