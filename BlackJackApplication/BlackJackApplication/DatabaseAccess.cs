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

        public async Task modifyPlayer(Player player)
        {
            FirebaseResponse response = await client.UpdateAsync<Player>("Players/" + player.Username, player);
            Player result = response.ResultAs<Player>();

            Console.WriteLine("Player Modified " + player.Username);
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
            FirebaseResponse response = await client.GetAsync("Players/" + username);
            Player player = response.ResultAs<Player>();
            if (player.Password.Trim() == password.Trim())
            {
                LoginValid = true;
            }
            else
            {
                LoginValid = false;
            }
        }

        
    }
}
