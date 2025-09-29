using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_7
{
    internal class Dice
    {
        public int _sides;
        public Dice(int _sides = 6) { this._sides = _sides; }
        public int Roll()
        {
            Random random = new Random();
            return random.Next(1, _sides + 1); // добавил +1 что бы включало последнюю грань
        }  
    }
}
