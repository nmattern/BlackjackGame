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
        List<GamePlayer> localPlayerList = new List<GamePlayer>();
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
            localPlayerList.Add(localPlayer);
            foreach(GamePlayer user in localPlayerList)
            {
                Console.WriteLine("User: " + user.Username);
            }
            database = db;
        }

        private async void createLocalGameButton_Click(object sender, EventArgs e)
        {
            await database.createLocalGame(localPlayerList[0].Username, localGame);
            playButton.Text = "Play Local Game";
            playButton.Enabled = true;
            createLocalGameButton.Visible = false;
            deleteLocalGameButton.Visible = true;
        }
        private async void deleteLocalGameButton_Click(object sender, EventArgs e)
        {
            await database.deleteLocalGame(localPlayerList[0].Username);
            createLocalGameButton.Text = "Create Local Game";
            createLocalGameButton.Visible = true;
            playButton.Text = "Play Solo";
            Player2PlayerListLabel.Text = "";
            Player3PlayerListLabel.Text = "";
            localPlayerList.Clear();
            localPlayerList.Add(localPlayer);
            localUserPlayerListLabel.Text = localPlayer.Username + " " + player.CurrentAmountOfMoney.ToString();
            deleteLocalGameButton.Visible = false;
        }

        private void setAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool betContainsOnlyDigits = Int32.TryParse(this.setAmountTextBox.Text, out number);
            if (betContainsOnlyDigits && this.setAmountTextBox.Text != "")
            {
                localPlayerList[0].PlayerAmountOfMoney = Convert.ToInt32(setAmountTextBox.Text);
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
            await database.doesLocalGameExist(localPlayerList[0].Username);
            if (database.LocalGameExists)
            {
                createLocalGameButton.Visible = false;
                if (localPlayerList.Count() <= 1)
                {
                    playButton.Text = "Play Solo";
                }
                else
                {
                    playButton.Text = "Play Local Game";
                }
                deleteLocalGameButton.Visible = true;
                // Check if guest1 exists
                await database.doesLocalPlayerExist(localPlayerList[0].Username, 1);
                if (database.LocalPlayerExists == true)
                {
                    await database.returnLocalPlayer(localPlayerList[0].Username, "1");
                    localPlayerList.Add(database.CurrentGamePlayer);
                    Player2PlayerListLabel.Text = "Guest1" + " " + database.CurrentGamePlayer.PlayerAmountOfMoney.ToString();
                    Player2PlayerListLabel.Visible = true;
                }
                // Check if guest2 exists
                await database.doesLocalPlayerExist(localPlayerList[0].Username, 2);
                if (database.LocalPlayerExists == true)
                {
                    await database.returnLocalPlayer(localPlayerList[0].Username, "2");
                    localPlayerList.Add(database.CurrentGamePlayer);
                    Player3PlayerListLabel.Text = "Guest2" + " " + database.CurrentGamePlayer.PlayerAmountOfMoney.ToString();
                    Player3PlayerListLabel.Visible = true;
                }
            }
            else
            {
                playButton.Text = "Play Solo";
                createLocalGameButton.Text = "Create Local Game";
                deleteLocalGameButton.Visible = false;
            }
            currentAmountOfMoneyLabel.Text = localPlayerList[0].PlayerAmountOfMoney.ToString();
            localUserPlayerListLabel.Text = localPlayerList[0].Username + " " + localPlayerList[0].PlayerAmountOfMoney.ToString();
            localPlayer = new GamePlayer();
            localPlayer.Username = localPlayerList[0].Username;
            localGame.GameID = 123;
            localGame.PlayerList.Add(localPlayer);
        }

        private async void adjustMoneyButton_Click(object sender, EventArgs e)
        {
            if (setAmountTextBox.Text != "")
            {
                await database.modifyEntirePlayer(player);
                currentAmountOfMoneyLabel.Text = localPlayerList[0].PlayerAmountOfMoney.ToString();
            }
        }

        private async void addLocalGuestButton_Click(object sender, EventArgs e)
        {
            GamePlayer newGuest;
            playButton.Enabled = false;
            if (localGame.PlayerList.Count < 3)
            {
                newGuest = generateGuest();
                localPlayerList.Add(newGuest);
                if (localPlayerList.Count == 2)
                {
                    await database.createLocalGamePlayer(localPlayerList[0].Username, 1, localPlayerList[1]);
                    Player2PlayerListLabel.Text = database.CurrentGamePlayer.Username + " " + database.CurrentGamePlayer.PlayerAmountOfMoney.ToString();
                    Player2PlayerListLabel.Visible = true;
                }
                else if (localPlayerList.Count == 3)
                {
                    await database.createLocalGamePlayer(localPlayerList[0].Username, 2, localPlayerList[2]);
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
            guestAccount.Username = "Guest" + localPlayerList.Count();
            guestAccount.PlayerAmountOfMoney = 1500;
            return guestAccount;
        }
        private async void deleteLocalGuestButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(localPlayerList.Count);
            if (localPlayerList.Count > 1)
            {
                localPlayerList.RemoveAt(localPlayerList.Count - 1);
                if (localPlayerList.Count == 2)
                {
                    Player3PlayerListLabel.Text = "";
                    Player3PlayerListLabel.Visible = false;
                    await database.deleteLocalGamePlayer(localPlayerList[0].Username, 2);
                }
                else if (localPlayerList.Count == 1)
                {
                    Player2PlayerListLabel.Text = "";
                    Player2PlayerListLabel.Visible = false;
                    await database.deleteLocalGamePlayer(localPlayerList[0].Username, 1);
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

        private void playButton_Click(object sender, EventArgs e)
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
