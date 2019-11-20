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
        private bool gameValid;
        private Player player;

        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = Credentials.ApiKey,
            BasePath = "https://blackjack-game-37aea.firebaseio.com/"
        };

        IFirebaseClient client = new FireSharp.FirebaseClient(config);

        public bool PlayerExists { get => this.playerExists; set => this.playerExists = value; }
        public bool LoginValid { get => this.loginValid; set => this.loginValid = value; }
        internal Player CurrentPlayer { get => this.player; set => this.player = value; }
        public bool GameValid { get => this.gameValid; set => this.gameValid = value; }

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

        public async Task modifySpecficPlayerData(string playerUserName, string fieldToModify, string Value)
        {
            // Check if the value is an integer and if it needs to be 64 bit
            if (Value.All(char.IsDigit) == true)
            {
                if (Value.Length > 8)
                {
                    Convert.ToInt64(Value);
                }
                else
                {
                    Convert.ToInt32(Value);
                }
            }

            // Otherwise modify the value for that player with the passed in value
            FirebaseResponse response = await client.GetAsync("Players/" + playerUserName + "/" + fieldToModify);
            Player databasePlayer = response.ResultAs<Player>();
            CurrentPlayer = databasePlayer;
        }

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

        
    }
}
