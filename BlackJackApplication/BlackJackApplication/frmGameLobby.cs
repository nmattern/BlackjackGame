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
    public partial class frmGameLobby : Form
    {
        List<Player> playerList = new List<Player>();
        DatabaseAccess database;
        internal frmGameLobby(Player p, DatabaseAccess db)
        {
            InitializeComponent();
            playerList.Add(p);
            foreach(Player user in playerList)
            {
                Console.WriteLine("User: " + user.Username);
            }
            database = db;
        }

        private void startLocalGameButton_Click(object sender, EventArgs e)
        {

        }

        private void joinOnlineGameButton_Click(object sender, EventArgs e)
        {

        }

        private void setAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool betContainsOnlyDigits = Int32.TryParse(this.setAmountTextBox.Text, out number);
            if (betContainsOnlyDigits && this.setAmountTextBox.Text != "")
            {
                // TODO update player money value in database
                playerList[0].CurrentAmountOfMoney = Convert.ToInt32(setAmountTextBox.Text);
            }
            else if (this.setAmountTextBox.Text == "")
            {
                AdjustMoneyErrorMessageLabel.Text = "Enter a number";
            }
            else
            {
                AdjustMoneyErrorMessageLabel.Text = "Not Valid";
            }
        }

        private void frmGameLobby_Load(object sender, EventArgs e)
        {
            localUserLabel.Text = playerList[0].Username;
            localUserPlayerListLabel.Text = playerList[0].Username;
        }

        private async void adjustMoneyButton_Click(object sender, EventArgs e)
        {
            await database.modifyEntirePlayer(playerList[0]);
        }

        private void addLocalGuestButton_Click(object sender, EventArgs e)
        {

        }
        private void deleteLocalGuestButton_Click(object sender, EventArgs e)
        {

        }

        private void createOnlineGameButton_Click(object sender, EventArgs e)
        {

        }

        private void joinOnlineGameButton_Click_1(object sender, EventArgs e)
        {

        }

    }
}
