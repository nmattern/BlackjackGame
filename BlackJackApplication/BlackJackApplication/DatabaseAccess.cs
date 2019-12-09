using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace BlackJackApplication
{
    class DatabaseAccess
    {
        private bool playerExists = true;
        private bool localPlayerExists;
        private bool loginValid;
        private bool localGameExists;
        private bool gameValid;
        private string gameID;
        private Player player;
        private GamePlayer gamePlayer;
        private LocalGame localGame;

        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = Credentials.ApiKey,
            BasePath = "https://blackjack-game-37aea.firebaseio.com/"
        };

        IFirebaseClient client = new FireSharp.FirebaseClient(config);

        public bool PlayerExists { get => this.playerExists; set => this.playerExists = value; }
        public bool LocalPlayerExists { get => this.localPlayerExists; set => this.localPlayerExists = value; }
        public bool LoginValid { get => this.loginValid; set => this.loginValid = value; }
        internal Player CurrentPlayer { get => this.player; set => this.player = value; }
        internal GamePlayer CurrentGamePlayer { get => this.gamePlayer; set => this.gamePlayer = value; }
        public bool GameValid { get => this.gameValid ; set => this.gameValid = value; }
        public string GameID { get => this.gameID; set => this.gameID = value; }

        public LocalGame LocalGame { get => this.localGame; set => this.localGame = value; }
        public bool LocalGameExists { get => localGameExists; set => localGameExists = value; }

        public void testConnection()
        {

            if (client != null)
            {
                Console.WriteLine("Connection Established");
            }
        }

        // General database endpoints
        // Create a player entry in the database
        public async Task createPlayer(Player player)
        {
            SetResponse response = await client.SetAsync<Player>("Players/" + player.Username, player);
            Player result = response.ResultAs<Player>();

            Console.WriteLine("Player Created " + player.Username);
        }

        public async Task setLocalPlayerLocation(List<Point> pointList, Player player)
        {
            int i;
            for (i = 0; i < player.ALocalGame.PlayerList.Count; i++)
            {
                SetResponse response = await client.SetAsync<GamePlayer>("Players/" + player.Username + "/LocalGame/PlayerList/" + i, player.ALocalGame.PlayerList[i]);
                GamePlayer result = response.ResultAs<GamePlayer>();

                Console.WriteLine("Local Player " + i + " has location " + player.ALocalGame.PlayerList[i].Location);
            }
            
        }
        /*
        public async Task updatePlayerList(Player player)
        {
            FirebaseResponse response = await client.GetAsync("Players/" + player.Username + "/LocalGame/PlayerList");
            LocalGame aLocalGame = response.ResultAs<LocalGame>();
        }
        */
        public async Task updateLocalGame(Player player)
        {
            FirebaseResponse response = await client.GetAsync("Players/" + player.Username + "/LocalGame");
            LocalGame aLocalGame = response.ResultAs<LocalGame>();
            LocalGame = aLocalGame;
        }

        public async Task modifyEntirePlayer(Player player)
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

        // Validate if a game exists which sets a boolean
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

        // Local Endpoints
        public async Task returnLocalPlayer(string parentUsername, string playerNumber)
        {
            FirebaseResponse response = await client.GetAsync("Players/" + parentUsername + "/LocalGame/PlayerList" + playerNumber);
            GamePlayer databasePlayer = response.ResultAs<GamePlayer>();
            CurrentGamePlayer = databasePlayer;
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

        public async Task createLocalGamePlayer(string parentUsername, int playerNumber, GamePlayer gamePlayer)
        {
            SetResponse response = await client.SetAsync<GamePlayer>("Players/" + parentUsername + "/LocalGame/PlayerList/" + playerNumber, gamePlayer);
            GamePlayer result = response.ResultAs<GamePlayer>();
            Console.WriteLine("Player Created " + player.Username);
        }

        public async Task deleteLocalGamePlayer(string parentUsername, int playerNumber)
        {
            FirebaseResponse response = await client.DeleteAsync("Players/" + parentUsername + "/LocalGame/PlayerList/" + playerNumber);
            Console.WriteLine("Deleted Local Game Player");
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

        public async Task doesLocalPlayerExist(string parentUsername, int playerNumber)
        {
            FirebaseResponse response = await client.GetAsync("Players/" + parentUsername + "/LocalGame/PlayerList/" + playerNumber);
            GamePlayer localPlayer = response.ResultAs<GamePlayer>();
            if (localPlayer != null)
            {
                LocalPlayerExists = true;
                Console.WriteLine("Local Player Exists");
            }
            else
            {
                LocalPlayerExists = false;
                Console.WriteLine("Local Player does not exist");
            }

        }

        // Online Endpoints and functionality

        public void GenerateOnlineID()
        {
            StringBuilder builder = new StringBuilder();
            Enumerable
               .Range(65, 26)
                .Select(e => ((char)e).ToString())
                .Concat(Enumerable.Range(97, 26).Select(e => ((char)e).ToString()))
                .Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
                .OrderBy(e => Guid.NewGuid())
                .Take(6)
                .ToList().ForEach(e => builder.Append(e));
            string returnValue = builder.ToString();
            
            gameID = returnValue;
            Console.WriteLine(gameID);
        }
    }
}
