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
    public partial class frmMainMenu : Form
    {
        DatabaseAccess database = new DatabaseAccess();
        Player player;
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void manageProfileButton_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm();
            profile.Show();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            // TODO Need to clear player data
            this.Close();
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            identityLabel.Text = "Signed in as: ";
            if (e.CloseReason == CloseReason.MdiFormClosing)
            {
                Application.Exit();
            }
            else
            {
                this.Hide();
            }
        }

        public async void retrievePlayer(string username)
        {
            await database.returnPlayer(username);
            player = database.CurrentPlayer;
            identityLabel.Text += database.CurrentPlayer.Username;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            updatePlayerMoney(Convert.ToInt32(setAmountTextBox.Text));
            var gameLobbyInstance = new frmGameLobby();
            gameLobbyInstance.Location = this.Location;
            this.Hide();
            // This is an event handler for the closing of a child form
            // Passes the subject (child form) and arguments to close 
            // Parent form as well
            gameLobbyInstance.Show();
            gameLobbyInstance.FormClosed += (s, args) => this.Close();
        }

        public async void updatePlayerMoney(int playerMoney)
        {
            await database.modifyPlayer(player);
        }

        private void setAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool betContainsOnlyDigits = Int32.TryParse(this.setAmountTextBox.Text, out number);
            if (betContainsOnlyDigits && this.setAmountTextBox.Text != "")
            {
                // TODO update player money value in database
                player.CurrentAmountOfMoney = Convert.ToInt32(setAmountTextBox.Text);
            }
            else if (this.setAmountTextBox.Text == "")
            {
                startingAmountValidLabel.Text = "Enter a number";
            }
            else
            {
                startingAmountValidLabel.Text = "Not Valid";
            }
        }
    }
}
