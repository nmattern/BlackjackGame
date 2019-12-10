using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BlackJackApplication
{
    public partial class CreateProfileForm : Form
    {
        bool nameErrorVerified = true;
        bool creditErrorVerified = true;
        bool phoneErrorVerified = true;
        bool usernameErrorVerified = true;
        bool confirmPasswordErrorVerified = true;

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
            confPasswordErrorLabel.Text = "";
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

        private async void submitButton_Click(object sender, EventArgs e)
        {
            string creditBox = Regex.Replace(creditCardTextBox.Text, "[^0-9]", "");
            string phoneBox = Regex.Replace(phoneTextBox.Text, "[^0-9]", "");
            bool verified = true;
            if (!this.nameTextBox.Text.All(char.IsLetter))
            {
                nameErrorLabel.Text = "Name must only contain letters";
                verified = false;
                nameErrorVerified = false;
            }
            else
            {
                nameErrorVerified = true;
                nameErrorLabel.Text = "";
            }

            if (creditBox.Length != 16)
            {
                creditCardErrorLabel.Text = "Credit card number must be 16 digits long";
                verified = false;
                creditErrorVerified = false;
            }
            else
            {
                creditErrorVerified = true;
                creditCardErrorLabel.Text = "";
                Console.WriteLine(creditBox);
            }
            
            if (phoneBox.Length == 10 || phoneBox.Length == 7)
            {
                Console.WriteLine(phoneBox);
                phoneErrorVerified = true;
                phoneErrorLabel.Text = "";
            }
            else
            {
                phoneErrorLabel.Text = "Please enter a valid phone number";
                Console.WriteLine(phoneBox);
                verified = false;
                phoneErrorVerified = false;
            }
            
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                confPasswordErrorLabel.Text = "Passwords do not match";
                verified = false;
                confirmPasswordErrorVerified = false;
            }
            else
            {
                confirmPasswordErrorVerified = true;
                confPasswordErrorLabel.Text = "";
            }

            await database.doesPlayerExist(this.usernameTextBox.Text);
            if (verified == true && database.PlayerExists == false) // so long as all fields are verified and the player is not in the db
            {
                
                Player newplayer = new Player(
                Convert.ToInt64(phoneBox), this.addressTextBox.Text, this.nameTextBox.Text,
                Convert.ToInt64(creditBox), this.recovQTextBox.Text, this.recovATextBox.Text,
                this.passwordTextBox.Text, this.usernameTextBox.Text, 34);
                await database.createPlayer(newplayer);
                clearTextBoxes();
                clearErrorLabels();
                this.Close();
            }
            else if (database.PlayerExists == true)
            {
                this.usernameNotValidLabel.Text = "Username already exists";
            }
            

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
