using System;
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
        DatabaseAccess database = new DatabaseAccess();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void signInButton_Click(object sender, EventArgs e)
        {
            await database.returnPlayer(usernameTextBox.Text);
            await database.isLoginValid(usernameTextBox.Text, passwordTextBox.Text);
            if (database.LoginValid)
            {
                var mainMenuInstance = new frmMainMenu();
                mainMenuInstance.Location = this.Location;
                this.Hide();
                // This is an event handler for the closing of a child form
                // Passes the subject (child form) and arguments to close 
                // Parent form as well
                mainMenuInstance.Show();
                mainMenuInstance.retrievePlayer(database.CurrentPlayer.Username);
                mainMenuInstance.FormClosed += (s, args) => this.Show();
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
            createPlayerFormInstance.FormClosed += (s, args) => this.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            usernameTextBox.Select();
        }


    }
}
