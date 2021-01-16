using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WHeditor
{
    public static class DiceRoll
    {
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();
        private static int RollBetween(int minimumValue, int maximumValue)
        {
            byte[] randomNumber = new byte[1];

            _generator.GetBytes(randomNumber);

            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

            // We are using Math.Max, and substracting 0.00000000001, 
            // to ensure "multiplier" will always be between 0.0 and .99999999999
            // Otherwise, it's possible for it to be "1", which causes problems in our rounding.

            double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);

            // We need to add one to the range, to allow for the rounding done with Math.Floor

            int range = maximumValue - minimumValue + 1;

            double randomValueInRange = Math.Floor(multiplier * range);

            return (int)(minimumValue + randomValueInRange);
        }
        public static int K_Ten()
        {
            return RollBetween(1, 10);
        }
        public static int K_OneHundred()
        {
            return RollBetween(1, 100);
        }
        public static int K_Twenty()
        {
            return RollBetween(1, 20);
        }
    }
}
