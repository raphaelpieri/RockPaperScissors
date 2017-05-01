using System.Collections.Generic;
using System.Linq;
using RockPaperScissors.Exceptions;
using RockPaperScissors.Lists;

namespace RockPaperScissors.Domain
{
    public class Game
    {
        public static Player RpsGameWinner(Match match)
        {
            if (match.Player1.Played.ToUpper() == match.Player2.Played.ToUpper())
                return match.Player1;

            var listOfPlayed = new ListOfPlayed();
            if(!listOfPlayed.VerifyIfValueIsValid(match.Player1.Played) || !listOfPlayed.VerifyIfValueIsValid(match.Player2.Played))
                throw new NoSuchStrategyError("Invalid Played");

            var played = new ListOfPlayed().FindOfPlayed(match.Player1.Played);
            if (played.Win.ToUpper() == match.Player2.Played.ToUpper())
                return match.Player1;
            else
                return match.Player2;
        }
    }
}