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
        GamePlayer localPlayer;

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

        private async void startLocalGameButton_Click(object sender, EventArgs e)
        {
            await database.createLocalGame(playerList[0].Username, localGame);
            startLocalGameButton.Text = "Load Previous Game";
            deleteLocalGameButton.Visible = true;
        }
        private async void deleteLocalGameButton_Click(object sender, EventArgs e)
        {
            await database.deleteLocalGame(playerList[0].Username);
            startLocalGameButton.Text = "Start Local Game";
            deleteLocalGameButton.Visible = false;
        }

        private void setAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool betContainsOnlyDigits = Int32.TryParse(this.setAmountTextBox.Text, out number);
            if (betContainsOnlyDigits && this.setAmountTextBox.Text != "")
            {
                playerList[0].CurrentAmountOfMoney = Convert.ToInt32(setAmountTextBox.Text);
                AdjustMoneyErrorMessageLabel.Text = "";
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

        private async void frmGameLobby_Load(object sender, EventArgs e)
        {
            await database.doesLocalGameExist(playerList[0].Username);
            if (database.LocalGameExists)
            {
                startLocalGameButton.Text = "Load Previous Game";
                deleteLocalGameButton.Visible = true;
                // Check if guest1 exists
                await database.doesLocalPlayerExist(playerList[0].Username, 1);
                if (database.LocalPlayerExists == true)
                {
                    Player2PlayerListLabel.Text = "Guest1";
                    Player2PlayerListLabel.Visible = true;
                }
                // Check if guest2 exists
                await database.doesLocalPlayerExist(playerList[0].Username, 2);
                if (database.LocalPlayerExists == true)
                {
                    Player3PlayerListLabel.Text = "Guest2";
                    Player3PlayerListLabel.Visible = true;
                }
            }
            else
            {
                startLocalGameButton.Text = "Start Local Game";
                deleteLocalGameButton.Visible = false;
            }
            currentAmountOfMoneyLabel.Text = playerList[0].CurrentAmountOfMoney.ToString();
            localUserPlayerListLabel.Text = playerList[0].Username;
            localPlayer = new GamePlayer();
            localPlayer.Username = playerList[0].Username;
            localGame.GameID = 123;
            localGame.PlayerList.Add(localPlayer);
        }

        private async void adjustMoneyButton_Click(object sender, EventArgs e)
        {
            if (setAmountTextBox.Text != "")
            {
                await database.modifyEntirePlayer(playerList[0]);
                currentAmountOfMoneyLabel.Text = playerList[0].CurrentAmountOfMoney.ToString();
            }
        }

        private async void addLocalGuestButton_Click(object sender, EventArgs e)
        {
            GamePlayer newGuest;
            if (localGame.PlayerList.Count <= 3)
            {
                newGuest = generateGuest();
                localGame.PlayerList.Add(newGuest);
                if (localGame.PlayerList.Count == 2)
                {
                    await database.createLocalGamePlayer(playerList[0].Username, 1, localGame.PlayerList[1]);
                    Player2PlayerListLabel.Text = newGuest.Username;
                    Player2PlayerListLabel.Visible = true;
                }
                else if (localGame.PlayerList.Count == 3)
                {
                    await database.createLocalGamePlayer(playerList[0].Username, 2, localGame.PlayerList[2]);
                    Player3PlayerListLabel.Text = newGuest.Username;
                    Player3PlayerListLabel.Visible = true;
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
        private async void deleteLocalGuestButton_Click(object sender, EventArgs e)
        {
            if (localGame.PlayerList.Count > 1)
            {
                localGame.PlayerList.RemoveAt(localGame.PlayerList.Count - 1);
                if (localGame.PlayerList.Count == 2)
                {
                    Player3PlayerListLabel.Text = "";
                    Player3PlayerListLabel.Visible = false;
                    await database.deleteLocalGamePlayer(playerList[0].Username, 2);
                }
                else if (localGame.PlayerList.Count == 1)
                {
                    Player2PlayerListLabel.Text = "";
                    Player2PlayerListLabel.Visible = false;
                    await database.deleteLocalGamePlayer(playerList[0].Username, 1);
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

        private void joinOnlineGameButton_Click(object sender, EventArgs e)
        {

        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            var gameBoardInstance = new frmGameBoard(playerList, database, localGame, localPlayer);
            gameBoardInstance.Location = this.Location;
            this.Hide();
            // This is an event handler for the closing of a child form
            // Passes the subject (child form) and arguments to close 
            // Parent form as well
            gameBoardInstance.Show();
            gameBoardInstance.FormClosed += (s, args) => this.Close();
        }
    }
}
