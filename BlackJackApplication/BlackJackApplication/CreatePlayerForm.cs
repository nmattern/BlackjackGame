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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            bool verified = true;
            if (!this.nameTextBox.Text.All(char.IsLetter))
            {
                // error message
                verified = false;
            }
            if (!this.creditCardTextBox.Text.All(char.IsDigit))
            {
                // error not all nums
                if(this.creditCardTextBox.Text.Length != 16)
                {
                    // wrong length error / not valid credit card
                }
                verified = false;
            }
            if(!this.phoneTextBox.Text.All(char.IsDigit))
            {
                //error not all nums
                if (this.phoneTextBox.Text.Length > 8 || this.phoneTextBox.Text.Length < 7)
                {
                    //not valid phone # error
                }
                verified = false;
            }

            if (verified == true) 
            {
                Console.WriteLine("made it");
                Player newplayer = new Player(
                Convert.ToInt64(phoneTextBox.Text), this.addressTextBox.Text, this.nameTextBox.Text,
                Convert.ToInt64(creditCardTextBox.Text), this.recovQTextBox.Text, this.recovATextBox.Text,
                this.passwordTextBox.Text, this.usernameTextBox.Text, 34);
                database.createPlayer(newplayer);
            }
            

        }
    }
}
