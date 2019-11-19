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

        public async void createPlayer(Player player)
        {
            client = new FireSharp.FirebaseClient(config);
            SetResponse response = await client.SetAsync<Player>("Players", player);
            Player result = response.ResultAs<Player>();

            Console.WriteLine("Player Created" + player.PlayerFBID);
        }

        public async void testCreatePlayer()
        {
            client = new FireSharp.FirebaseClient(config);
            Player player = new Player(
                1234567890,
                "address",
                "name",
                111111111,
                "Dog",
                "What is your first pets name?",
                "password",
                "testuser",
                1);

            SetResponse response = await client.SetAsync<Player>("Players/"+player.Username, player);
            Player result = response.ResultAs<Player>();

            Console.WriteLine("Player Created" + player.PlayerFBID);
        }
    }
}
