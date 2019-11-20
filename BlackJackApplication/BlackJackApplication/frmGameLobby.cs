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
        LocalGame localGame = new LocalGame();

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
            localUserPlayerListLabel.Text = playerList[0].Username;
            GamePlayer localPlayer = new GamePlayer();
            localPlayer.Username = playerList[0].Username;
            localPlayer.PlayerAmountOfMoney = playerList[0].CurrentAmountOfMoney;
            localGame.GameID = 123;
            localGame.PlayerList.Add(localPlayer);
        }

        private async void adjustMoneyButton_Click(object sender, EventArgs e)
        {
            await database.modifyEntirePlayer(playerList[0]);
        }

        private void addLocalGuestButton_Click(object sender, EventArgs e)
        {
            GamePlayer newGuest;
            if (localGame.PlayerList.Count < 3)
            {
                newGuest = generateGuest();
                localGame.PlayerList.Add(newGuest);
                if (localGame.PlayerList.Count == 2)
                {
                    Player2PlayerListLabel.Text = newGuest.Username;
                }
                else if (localGame.PlayerList.Count == 3)
                {
                    Player3PlayerListLabel.Text = newGuest.Username;
                } 
            }
            else
            {
                Console.WriteLine("Already at max players");
            }
            foreach(GamePlayer player in localGame.PlayerList)
            {
                Console.WriteLine(player.Username);
            }
        }

        private GamePlayer generateGuest()
        {
            GamePlayer guestAccount = new GamePlayer();
            guestAccount.Username = "Guest" + localGame.PlayerList.Count();
            guestAccount.PlayerAmountOfMoney = 1500;
            return guestAccount;
        }
        private void deleteLocalGuestButton_Click(object sender, EventArgs e)
        {
            if (localGame.PlayerList.Count > 1)
            {
                localGame.PlayerList.RemoveAt(localGame.PlayerList.Count - 1);
                if (localGame.PlayerList.Count == 2)
                {
                    Player3PlayerListLabel.Text = "Player 3";
                }
                else if (localGame.PlayerList.Count == 1)
                {
                    Player2PlayerListLabel.Text = "Player 2";
                }
            }
            else
            {
                Console.WriteLine("Can not delete any more entries");
            }
        }

        private void createOnlineGameButton_Click(object sender, EventArgs e)
        {

        }

        private void joinOnlineGameButton_Click_1(object sender, EventArgs e)
        {

        }

    }
}
