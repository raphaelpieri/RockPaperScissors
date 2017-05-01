using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.Domain
{
    public class Match
    {
        public Match(Player player)
        {
            Player1 = player;
        }
        public Match(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }

        public void AddPlayer2(Player player)
        {
            this.Player2 = player;
        }
    }
}