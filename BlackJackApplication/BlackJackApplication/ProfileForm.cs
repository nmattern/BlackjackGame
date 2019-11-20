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
            if (this.profileNameTextBox.Text.All(char.IsLetter) == true)
            {
                if (this.profilePhoneNumberTextBox.Text.Length <= 11 && this.profilePhoneNumberTextBox.Text.Length > 9)
                {
                    if (this.profileCreditCardTextBox.Text.Length == 16)
                    {
                        Valid = true;
                    }
                    else
                    {

                    }
                }
            }
            if (Valid == true)
            {
                player.Name = this.profileNameTextBox.Text;
                player.Address = this.profileAddressTextBox.Text;
                player.Phone = Convert.ToInt64(this.profilePhoneNumberTextBox.Text);
                player.CreditC = Convert.ToInt64(this.profileCreditCardTextBox.Text);
                await database.modifyPlayer(player);
                this.Close();
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
        }
    }
}
