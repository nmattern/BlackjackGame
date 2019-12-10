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
        GamePlayer localPlayer = new GamePlayer();
        Player player;

        internal frmGameLobby(Player p, DatabaseAccess db)
        {
            InitializeComponent();
            player = p;
            localPlayer.Username = player.Username;
            localPlayer.PlayerAmountOfMoney = player.CurrentAmountOfMoney;
            localGame.PlayerList.Add(localPlayer);
            foreach(GamePlayer user in localGame.PlayerList)
            {
                Console.WriteLine("User: " + user.Username);
            }
            database = db;
        }

        private void setAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool betContainsOnlyDigits = Int32.TryParse(this.setAmountTextBox.Text, out number);
            if (betContainsOnlyDigits && this.setAmountTextBox.Text != "")
            {
                localGame.PlayerList[0].PlayerAmountOfMoney = Convert.ToInt32(setAmountTextBox.Text);
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
            Console.WriteLine(localGame.PlayerList.Count());
            await database.doesLocalGameExist(localGame.PlayerList[0].Username);
            if (database.LocalGameExists)
            {
                if (localGame.PlayerList.Count() <= 1)
                {
                    playButton.Text = "Play Solo";
                }
                else
                {
                    playButton.Text = "Play Local Game";
                }
                // Check if guest1 exists
                await database.doesLocalPlayerExist(localGame.PlayerList[0].Username, 1);
                if (database.LocalPlayerExists == true)
                {
                    playButton.Text = "Play Local Game";
                    await database.returnLocalPlayer(localGame.PlayerList[0].Username, "1");
                    localGame.PlayerList.Add(database.CurrentGamePlayer);
                    Player2PlayerListLabel.Text = "Guest1" + " " + database.CurrentGamePlayer.PlayerAmountOfMoney.ToString();
                    Player2PlayerListLabel.Visible = true;
                }
                // Check if guest2 exists
                await database.doesLocalPlayerExist(localGame.PlayerList[0].Username, 2);
                if (database.LocalPlayerExists == true)
                {
                    await database.returnLocalPlayer(localGame.PlayerList[0].Username, "2");
                    localGame.PlayerList.Add(database.CurrentGamePlayer);
                    Player3PlayerListLabel.Text = "Guest2" + " " + database.CurrentGamePlayer.PlayerAmountOfMoney.ToString();
                    Player3PlayerListLabel.Visible = true;
                }
            }
            else
            {
                playButton.Text = "Play Solo";
            }
            currentAmountOfMoneyLabel.Text = localGame.PlayerList[0].PlayerAmountOfMoney.ToString();
            localUserPlayerListLabel.Text = localGame.PlayerList[0].Username + " " + localGame.PlayerList[0].PlayerAmountOfMoney.ToString();
        }

        private async void adjustMoneyButton_Click(object sender, EventArgs e)
        {
            if (setAmountTextBox.Text != "")
            {
                await database.modifyEntirePlayer(player);
                currentAmountOfMoneyLabel.Text = localGame.PlayerList[0].PlayerAmountOfMoney.ToString();
            }
        }

        private async void addLocalGuestButton_Click(object sender, EventArgs e)
        {
            GamePlayer newGuest;
            playButton.Text = "Play Local Game";
            if (localGame.PlayerList.Count < 3)
            {
                newGuest = generateGuest();
                localGame.PlayerList.Add(newGuest);
                if (localGame.PlayerList.Count == 2)
                {
                    await database.createLocalGamePlayer(localGame.PlayerList[0].Username, 1, localGame.PlayerList[1]);
                    Player2PlayerListLabel.Text = database.CurrentGamePlayer.Username + " " + database.CurrentGamePlayer.PlayerAmountOfMoney.ToString();
                    Player2PlayerListLabel.Visible = true;
                }
                else if (localGame.PlayerList.Count == 3)
                {
                    await database.createLocalGamePlayer(localGame.PlayerList[0].Username, 2, localGame.PlayerList[2]);
                    Player3PlayerListLabel.Text = database.CurrentGamePlayer.Username + " " + database.CurrentGamePlayer.PlayerAmountOfMoney.ToString();
                    Player3PlayerListLabel.Visible = true;
                } 
            }
            else
            {
                Console.WriteLine("Already at max players");
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
            Console.WriteLine(localGame.PlayerList.Count);
            if (localGame.PlayerList.Count > 1)
            {
                localGame.PlayerList.RemoveAt(localGame.PlayerList.Count - 1);
                if (localGame.PlayerList.Count == 2)
                {
                    Player3PlayerListLabel.Text = "";
                    Player3PlayerListLabel.Visible = false;
                    await database.deleteLocalGamePlayer(localGame.PlayerList[0].Username, 2);
                }
                else if (localGame.PlayerList.Count == 1)
                {
                    Player2PlayerListLabel.Text = "";
                    Player2PlayerListLabel.Visible = false;
                    await database.deleteLocalGamePlayer(localGame.PlayerList[0].Username, 1);
                    playButton.Text = "Play Solo";
                }
            }
            else
            {
                Console.WriteLine("Can not delete any more entries");
            }
        }

        private void createOnlineGameButton_Click(object sender, EventArgs e)
        {
            database.GenerateOnlineID();
        }

        private void joinOnlineGameButton_Click(object sender, EventArgs e)
        {

        }

        private async void playButton_Click(object sender, EventArgs e)
        {
            await database.createLocalGame(localGame.PlayerList[0].Username, localGame);
            await database.returnPlayer(localGame.PlayerList[0].Username);
            await database.doesLocalPlayerExist(localGame.PlayerList[0].Username, 0);
            if (database.LocalPlayerExists)
            {
                playerList.Add(database.CurrentPlayer);
            }
            frmGameBoard gameBoardInstance = new frmGameBoard(playerList, database, localGame)
            {
                Location = this.Location
            };
            this.Hide();
            // This is an event handler for the closing of a child form
            // Passes the subject (child form) and arguments to close 
            // Parent form as well
            gameBoardInstance.Show();
            gameBoardInstance.FormClosed += (s, args) => this.Close();
        }
    }
}
