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
    public partial class CreateProfileForm : Form
    {
        DatabaseAccess database = new DatabaseAccess();
        public CreateProfileForm()
        {
            InitializeComponent();
        }

        private void clearErrorLabels()
        {
            nameErrorLabel.Text = "";
            creditCardErrorLabel.Text = "";
            phoneErrorLabel.Text = "";
            usernameNotValidLabel.Text = "";
        }

        private void clearTextBoxes()
        {
            this.nameTextBox.Text = "";
            this.usernameTextBox.Text = "";
            this.passwordTextBox.Text = "";
            this.confirmPasswordTextBox.Text = "";
            this.phoneTextBox.Text = "";
            this.creditCardTextBox.Text = "";
            this.recovQTextBox.Text = "";
            this.recovATextBox.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            bool verified = true;
            if (!this.nameTextBox.Text.All(char.IsLetter))
            {
                nameErrorLabel.Text = "Name must only contain letters";
                verified = false;
            }
            if (!this.creditCardTextBox.Text.All(char.IsDigit))
            {
                creditCardErrorLabel.Text = "Credit card number must only contain numbers";
                if(this.creditCardTextBox.Text.Length != 16)
                {
                    creditCardErrorLabel.Text = "Credit card number must be in format '1234123412341234'";
                }
                verified = false;
            }
            if(!this.phoneTextBox.Text.All(char.IsDigit))
            {
                phoneErrorLabel.Text = "Phone number must only contain numbers";
                if (this.phoneTextBox.Text.Length > 11 || this.phoneTextBox.Text.Length < 10)
                {
                    phoneErrorLabel.Text = "Phone number must be 10-11 characters long";
                }
                verified = false;
            }

            database.doesPlayerExist(this.usernameTextBox.Text);
            if (verified == true && database.PlayerExists == false) // so long as all fields are verified and the player is not in the db
            {
                
                Player newplayer = new Player(
                Convert.ToInt64(phoneTextBox.Text), this.addressTextBox.Text, this.nameTextBox.Text,
                Convert.ToInt64(creditCardTextBox.Text), this.recovQTextBox.Text, this.recovATextBox.Text,
                this.passwordTextBox.Text, this.usernameTextBox.Text, 34);
                database.createPlayer(newplayer);
                clearTextBoxes();
                clearErrorLabels();
                var gameLobbyInstance = new frmGameLobby();
                gameLobbyInstance.Show();
                gameLobbyInstance.Location = this.Location;
                this.Hide();
                // This is an event handler for the closing of a child form
                // Passes the subject (child form) and arguments to close 
                // Parent form as well
                gameLobbyInstance.FormClosed += (s, args) => this.Close();
            }
            else if (database.PlayerExists == true)
            {
                this.usernameNotValidLabel.Text = "Username already exists";
            }
            

        }
    }
}
