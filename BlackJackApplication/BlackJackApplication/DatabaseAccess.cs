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
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = Credentials.ApiKey,
            BasePath = "https://blackjack-game-37aea.firebaseio.com/"
        };

        IFirebaseClient client;

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
            SetResponse response = await client.SetAsync<Player>("Players/" + player.PlayerFBID, player);
            Player result = response.ResultAs<Player>();

            Console.WriteLine("Player Created" + player.PlayerFBID);
        }

        //  Verify if the user exists and return a boolean
        public async void doesPlayerExist(string username)
        {
            FirebaseResponse response = await client.GetAsync("Players/" + username);
            Player player = response.ResultAs<Player>();
            Console.WriteLine(player);
            playerExists(player);
        }

        public bool playerExists(Player player)
        {
            if (player != null)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
