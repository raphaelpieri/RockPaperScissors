namespace RockPaperScissors.Lists
{
    public class TypeOfPlayed
    {
        public TypeOfPlayed(string played, string win)
        {
            Played = played;
            Win = win;
        }
        public string Played { get; private set; }
        public string Win { get; private set; }
    }
}