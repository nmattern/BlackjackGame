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
        private bool playerExists;
        private bool loginValid;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = Credentials.ApiKey,
            BasePath = "https://blackjack-game-37aea.firebaseio.com/"
        };

        IFirebaseClient client;
        client = new FireSharp.FirebaseClient(config);

        public bool PlayerExists { get => this.playerExists; set => this.playerExists = value; }
        public bool LoginValid { get => this.loginValid; set => this.loginValid = value; }

        public void testConnection()
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                Console.WriteLine("Connection Established");
            }
        }

        // Create a player entry in the database
        public async void createPlayer(Player player)
        {
            SetResponse response = await client.SetAsync<Player>("Players/" + player.Username, player);
            Player result = response.ResultAs<Player>();

            Console.WriteLine("Player Created" + player.Username);
        }

        //  Verify if the user exists and return a boolean
        public async void doesPlayerExist(string username)
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
        public async void isLoginValid(string username, string password)
        {
            FirebaseResponse response = await client.GetAsync("Players/" + username);
            Player player = response.ResultAs<Player>();
            if (player.Password == password)
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
