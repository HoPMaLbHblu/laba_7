using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_7
{
    class PickRandomCards
    {
        static Random rand = new Random();
        public static string[] PickSomeCards(int numOfCards)
        {
            string[] pickedCards = new string[numOfCards];
            for (int i = 0; i < numOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            int value = rand.Next(1, 5);
            if (value == 1) return "пик";
            if (value == 2) return "червей";
            if (value == 3) return "треф";

            return "бубен";
        }
        private static string RandomValue()
        {
            int value = rand.Next(1, 14);
            if (value == 10) return "Туз";
            if (value == 11) return "Валет";
            if (value == 12) return "Дама";
            if (value == 13) return "Король";
            return value.ToString();
        }

    }
}
