namespace RockPaperScissors.Domain
{
    public class Player
    {
        public Player(string name, string played)
        {
            Name = name;
            Played = played;
        }
        public string Name { get; private set; }
        public string Played { get; private set; }
    }
}