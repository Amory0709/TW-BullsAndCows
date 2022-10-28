using System;
using System.Linq;

namespace BullsAndCows
{
    public class BullsAndCowsGame
    {
        private readonly SecretGenerator secretGenerator;
        private string secret;
        public BullsAndCowsGame(SecretGenerator secretGenerator)
        {
            this.secretGenerator = secretGenerator;
            this.secret = secretGenerator.GenerateSecret();
        }

        public bool CanContinue => true;

        public string Guess(string guess)
        {
            int counter = CountBulls(guess);

            return $"{counter}A0B";
        }

        private int CountBulls(string guess)
        {
            var guessDigits = guess.Split(" ");
            var secretDigits = secret.Split(" ");
            return guessDigits.Where((t, i) => t == secretDigits[i]).Count();
        }
    }
}