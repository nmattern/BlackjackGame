using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace BlackJackApplication
{
    class DatabaseAccess
    {
        private bool playerExists = true;
        private bool loginValid;
        private bool localGameExists;
        private bool gameValid;
        private Player player;
        private LocalGame localGame;

        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = Credentials.ApiKey,
            BasePath = "https://blackjack-game-37aea.firebaseio.com/"
        };

        IFirebaseClient client = new FireSharp.FirebaseClient(config);

        public bool PlayerExists { get => this.playerExists; set => this.playerExists = value; }
        public bool LoginValid { get => this.loginValid; set => this.loginValid = value; }
        internal Player CurrentPlayer { get => this.player; set => this.player = value; }
        public bool GameValid { get => this.gameValid ; set => this.gameValid = value; }

        public LocalGame LocalGame { get => this.localGame; set => this.localGame = value; }
        public bool LocalGameExists { get => localGameExists; set => localGameExists = value; }

        public void testConnection()
        {

            if (client != null)
            {
                Console.WriteLine("Connection Established");
            }
        }

        // Create a player entry in the database
        public async Task createPlayer(Player player)
        {
            SetResponse response = await client.SetAsync<Player>("Players/" + player.Username, player);
            Player result = response.ResultAs<Player>();

            Console.WriteLine("Player Created " + player.Username);
        }

        public async Task modifyEntirePlayer(Player player)
        {
            FirebaseResponse response = await client.UpdateAsync<Player>("Players/" + player.Username, player);
            Player result = response.ResultAs<Player>();

            Console.WriteLine("Player Modified " + player.Username);
        }

        // TODO
        /*public async Task modifySpecficPlayerData(string playerUserName, string fieldToModify, string Value)
        {
            FirebaseResponse response = await client.GetAsync("Players/" + playerUserName + "/" + fieldToModify);
            // Check if the value is an integer and if it needs to be 64 bit
            if (Value.All(char.IsDigit) == true)
            {
                if (Value.Length > 8)
                {
                    Convert.ToInt64(Value);
                    Int64 playerData = response.ResultAs<Int64>();
                    typeof(MyType).GetMethod("CurrentPlayer." + fieldToModify).Invoke(null, new[] { arg1, arg2 });
                    CurrentPlayer.fieldToModify
                }
                else
                {
                    Convert.ToInt32(Value);
                }
            }

            // Otherwise modify the value for that player with the passed in value
            Player databasePlayer = response.ResultAs<Player>();
            CurrentPlayer = databasePlayer;
        }*/

        // Grabs the player class from the databased assigned to that username
        public async Task returnPlayer(string username)
        {
            FirebaseResponse response = await client.GetAsync("Players/" + username);
            Player databasePlayer = response.ResultAs<Player>();
            CurrentPlayer = databasePlayer;
        }

        //  Verify if the user exists and return a boolean
        public async Task doesPlayerExist(string username)
        {
            FirebaseResponse response = await client.GetAsync("Players/" + username);
            Player player = response.ResultAs<Player>();
            if (player != null)
            {
                playerExists = true;
                Console.WriteLine("Player Exists");
            }
            else
            {
                playerExists = false;
                Console.WriteLine("Player does not exist");
            }
        }

        // Validate if a login is valid
        public async Task isLoginValid(string username, string password)
        {
            FirebaseResponse response = await client.GetAsync("Players/" + username + "/Password");
            String passwordResponse = response.ResultAs<String>();
            if (passwordResponse.Trim() == password.Trim())
            {
                LoginValid = true;
            }
            else
            {
                LoginValid = false;
            }
        }

        public async Task createLocalGame(string username, LocalGame localGame)
        {
            SetResponse response = await client.SetAsync<LocalGame>("Players/" + username + "/LocalGame/", localGame);
            LocalGame result = response.ResultAs<LocalGame>();

            Console.WriteLine("Local Game created for " + username);
        }

        public async Task deleteLocalGame(string username)
        {
            FirebaseResponse response = await client.DeleteAsync("Players/" + username + "/LocalGame");
            Console.WriteLine("Deleted Local Game for " + username);
        }

        public async Task isGameValid(int gameID)
        {
            FirebaseResponse response = await client.GetAsync("Games/" + gameID);
            int databaseGameId = response.ResultAs<int>();
            if (databaseGameId == gameID)
            {
                GameValid = true;
            }
            else
            {
                GameValid = false;
            }
        }

        public async Task doesLocalGameExist(string username)
        {
            FirebaseResponse response = await client.GetAsync("Players/" + username + "/LocalGame");
            LocalGame localGame = response.ResultAs<LocalGame>();
            if (localGame != null)
            {
                localGameExists = true;
                Console.WriteLine("Local Game Exists");
            }
            else
            {
                localGameExists = false;
                Console.WriteLine("Local Game does not exist");
            }

        }

        
    }
}
