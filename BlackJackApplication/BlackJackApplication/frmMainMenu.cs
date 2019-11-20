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

        internal Player givePlayer()
        {
            return player;
        }
        internal DatabaseAccess giveDB()
        {
            return database;
        }

        private void manageProfileButton_Click(object sender, EventArgs e)
        {
            var profileInstance = new ProfileForm(player, database);
            profileInstance.Location = this.Location;
            this.Hide();
            // This is an event handler for the closing of a child form
            // Passes the subject (child form) and arguments to close 
            // Parent form as well
            profileInstance.Show();
            profileInstance.FormClosed += (s, args) => this.Show();
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
            var gameLobbyInstance = new frmGameLobby(player, database);
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



        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
