using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApplication
{
    class LocalGame
    {
        private int gameID;
        private List<GamePlayer> playerList = new List<GamePlayer>();

        public int GameID { get => gameID; set => gameID = value; }
        public List<GamePlayer> PlayerList { get => playerList; set => playerList = value; }



    }
}
