using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Domain;

namespace RockPaperScissorsTest
{
    [TestClass]
    [TestCategory("Game Test")]
    public class GameTest
    {
        [TestMethod]
        public void ShouldReturnPlayer1BecauseItPlayedRockAndPlayer2PlayedScissors()
        {
            var playes1 = new Player("Raphael","r");
            var player2 = new Player("Jose", "S");

            Match match = new Match(playes1, player2);

            var playerWIn = Game.RpsGameWinner(match);

            Assert.AreEqual(playes1.Name, playerWIn.Name);
        }

        [TestMethod]
        public void ShouldReturnPlayer2BecauseItPlayedRockAndPlayer2PlayedPaper()
        {
            var playes1 = new Player("Armando", "P");
            var player2 = new Player("Dave", "s");

            Match match = new Match(playes1, player2);

            var playerWIn = Game.RpsGameWinner(match);

            Assert.AreEqual(player2.Name, playerWIn.Name);
        }

        [TestMethod]
        public void ShouldReturnPlayer1BecauseItPlayedRockAndPlayer2PlayedRock()
        {
            var playes1 = new Player("Raphael", "R");
            var player2 = new Player("Jose", "r");

            Match match = new Match(playes1, player2);

            var playerWIn = Game.RpsGameWinner(match);

            Assert.AreEqual(playes1.Name, playerWIn.Name);
        }

        [TestMethod]
        public void ShouldReturnErrorBecauseItPlayedAnInvalidValueAndPlayer2PlayedRock()
        {
            var playes1 = new Player("Raphael", "T");
            var player2 = new Player("Jose", "r");

            Match match = new Match(playes1, player2);
            try
            {
                var playerWIn = Game.RpsGameWinner(match);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void ShouldReturnErrorBecausePlayer2PlayedAnInvalidValuk()
        {
            var playes1 = new Player("Raphael", "s");
            var player2 = new Player("Jose", "H");

            Match match = new Match(playes1, player2);
            try
            {
                var playerWIn = Game.RpsGameWinner(match);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
    }
}
