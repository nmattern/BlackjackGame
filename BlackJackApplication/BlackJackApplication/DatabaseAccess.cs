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

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = Credentials.ApiKey,
            BasePath = "https://blackjack-game-37aea.firebaseio.com/"
        };

        IFirebaseClient client;

        public bool PlayerExists { get => this.playerExists; set => this.playerExists = value; }

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
            client = new FireSharp.FirebaseClient(config);
            SetResponse response = await client.SetAsync<Player>("Players/" + player.Username, player);
            Player result = response.ResultAs<Player>();

            Console.WriteLine("Player Created" + player.Username);
        }

        //  Verify if the user exists and return a boolean
        public async void doesPlayerExist(string username)
        {
            client = new FireSharp.FirebaseClient(config);
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

        
    }
}
