using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOneGame
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        public List<Player> Players { get { return _players; } set { _players = value; } }
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public string Name { get; set; }
        public string Dealer { get; set; }
        public abstract void Play(); 
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
