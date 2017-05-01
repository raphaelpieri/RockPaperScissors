using System;
using System.Collections.Generic;

namespace RockPaperScissors.Domain
{
    public class Tournament
    {
        public Player PlayGame(List<Match> matches, Player winPlayer = null)
        {
            if (winPlayer == null)
            {
                if (matches.Count % 2 == 0)
                {
                    List<Match> auxiList = new List<Match>();
                    Match auxMatch = null;
                    matches.ForEach(match =>
                    {
                        var auxPlayer = Game.RpsGameWinner(match);
                        if (auxMatch == null)
                            auxMatch = new Match(auxPlayer);
                        else
                        {
                            auxMatch.AddPlayer2(auxPlayer);
                            auxiList.Add(auxMatch);
                            auxMatch = null;
                        }
                    });
                    winPlayer = PlayGame(auxiList, winPlayer);
                }
                else if (matches.Count > 1)
                {
                    throw new Exception("Number of match invalid");
                }

                if (matches.Count == 1)
                    winPlayer = Game.RpsGameWinner(matches[0]);
            }

            return winPlayer;
        }
    }
}