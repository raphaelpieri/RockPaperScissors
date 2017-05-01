using System.Collections.Generic;
using System.Linq;
using RockPaperScissors.Exceptions;

namespace RockPaperScissors.Lists
{
    public class ListOfPlayed
    {
        private readonly List<TypeOfPlayed> _playeds;
        public ListOfPlayed()
        {
            _playeds = new List<TypeOfPlayed>();

            _playeds.Add(new TypeOfPlayed("R", "S"));
            _playeds.Add(new TypeOfPlayed("P", "R"));
            _playeds.Add(new TypeOfPlayed("S", "P"));
        }

        public TypeOfPlayed FindOfPlayed(string played)
        {
            var result = _playeds.Where(x => x.Played.ToUpper() == played.ToUpper()).FirstOrDefault();
            return result;
        }

        public bool VerifyIfValueIsValid(string played)
        {
            return _playeds.Exists(x => x.Played.ToUpper() == played.ToUpper());
        }
    }
}