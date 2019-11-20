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
    public partial class ProfileForm : Form
    {
        Player player;
        bool Valid = false;
        DatabaseAccess database;
        internal ProfileForm(Player p, DatabaseAccess db)
        {
            InitializeComponent();
            player = p;
            database = db;
        }

        private async void confirmButton_Click(object sender, EventArgs e)
        {
            if (this.profileNameTextBox.Text.All(char.IsLetter) == true || this.profileNameTextBox.Text == "")
            {
                if (this.profilePhoneNumberTextBox.Text.Length <= 11 
                    && this.profilePhoneNumberTextBox.Text.Length > 9
                    || this.profilePhoneNumberTextBox.Text == "")
                {
                    if (this.profileCreditCardTextBox.Text.Length == 16
                        && this.profileNameTextBox.Text.All(char.IsDigit)
                        || this.profileCreditCardTextBox.Text == "")
                    {
                        Valid = true;
                    }
                    else
                    {
                        this.creditCardErrorLabel.Text = "Credit card must be 16 digit number";
                    }
                }
            }
            if (Valid == true)
            {
                if (this.profileNameTextBox.Text != "")
                {
                    player.Name = this.profileNameTextBox.Text;
                }
                if (this.profilePhoneNumberTextBox.Text != "")
                {
                    player.CreditC = Convert.ToInt64(this.profileCreditCardTextBox.Text);
                }
                if (this.profileAddressTextBox.Text != "")
                {
                    player.Address = this.profileAddressTextBox.Text;
                }
                if (this.profileCreditCardTextBox.Text != "")
                {
                    player.Phone = Convert.ToInt64(this.profilePhoneNumberTextBox.Text);
                }

                await database.modifyPlayer(player);
                this.Close();
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
        }
    }
}
