﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackApplication
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            signInLabel.Text = "Player Sign In";
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            DatabaseAccess database = new DatabaseAccess();
            database.isLoginValid(usernameTextBox.Text, passwordTextBox.Text);
            if (database.LoginValid)
            {
                database.returnPlayer(usernameTextBox.Text);
                var mainMenuInstance = new frmMainMenu();
                mainMenuInstance.Show();
                mainMenuInstance.Location = this.Location;
                this.Hide();
                // This is an event handler for the closing of a child form
                // Passes the subject (child form) and arguments to close 
                // Parent form as well
                mainMenuInstance.FormClosed += (s, args) => this.Close();
            }
            else
            {
                incorrectLoginLabel.Text = "Invalid username or password";
            }
        }

        private void createProfileButton_Click(object sender, EventArgs e)
        {
            var createPlayerFormInstance = new CreateProfileForm();
            createPlayerFormInstance.Show();
            createPlayerFormInstance.Location = this.Location;
            this.Hide();
            // This is an event handler for the closing of a child form
            // Passes the subject (child form) and arguments to close 
            // Parent form as well
            createPlayerFormInstance.FormClosed += (s, args) => this.Close();
        }
    }
}
