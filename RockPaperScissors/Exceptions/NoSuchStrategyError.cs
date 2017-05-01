using System;

namespace RockPaperScissors.Exceptions
{
    public class NoSuchStrategyError : Exception
    {
        public NoSuchStrategyError(string text) : base(text) { }
    }
}