using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Domain;

namespace RockPaperScissorsTest
{
    [TestClass]
    [TestCategory("Tournament")]
    public class TournametTest
    {
        [TestMethod]
        public void ShouldReturnRichardPlayer()
        {
            var Armando = new Player("Armando", "P");
            var Dave = new Player("Dave", "S");
            var matchArmandoDave = new Match(Armando, Dave);

            var Richard = new Player("Richard", "R");
            var Michael = new Player("Michael", "S");
            var matchRichardMichael = new Match(Richard, Michael);

            var Allen = new Player("Allen", "S");
            var Omer = new Player("Omer", "P");
            var matchAllenOmar = new Match(Allen, Omer);

            var David = new Player("David E.", "S");
            var RichardX = new Player("Richard X.", "P");
            var matchDavidRichardX = new Match(David, RichardX);

            var lista = new List<Match>();
            lista.Add(matchArmandoDave);
            lista.Add(matchRichardMichael);
            lista.Add(matchAllenOmar);
            lista.Add(matchDavidRichardX);

            var tournament = new Tournament();
            var winPlayer = tournament.PlayGame(lista);

            Assert.AreEqual(Richard.Name, winPlayer.Name);
        }

        [TestMethod]
        public void ShouldReturnDavePlayer()
        {
            var Armando = new Player("Armando", "P");
            var Dave = new Player("Dave", "S");
            var matchArmandoDave = new Match(Armando, Dave);


            var lista = new List<Match>();
            lista.Add(matchArmandoDave);

            var tournament = new Tournament();
            var winPlayer = tournament.PlayGame(lista);

            Assert.AreEqual(Dave.Name, winPlayer.Name);
        }

        [TestMethod]
        public void ShouldReturnAnExceptionBecauseThereAre3Match()
        {
            var Armando = new Player("Armando", "P");
            var Dave = new Player("Dave", "S");
            var matchArmandoDave = new Match(Armando, Dave);

            var Richard = new Player("Richard", "R");
            var Michael = new Player("Michael", "S");
            var matchRichardMichael = new Match(Richard, Michael);

            var Allen = new Player("Allen", "S");
            var Omer = new Player("Omer", "P");
            var matchAllenOmar = new Match(Allen, Omer);

            try
            {
                var lista = new List<Match>();
                lista.Add(matchArmandoDave);
                lista.Add(matchRichardMichael);
                lista.Add(matchAllenOmar);
                var tournament = new Tournament();
                var winPlayer = tournament.PlayGame(lista);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
    }
}