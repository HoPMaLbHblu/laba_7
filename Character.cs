using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_7
{
    internal class Character
    {
        int Health;
        int Mana;
        public Character(int Health, int Mana)
        {
            this.Health = Health;
            this.Mana = Mana;
        }
        public void Attack()
        {
            Console.WriteLine("Персонаж атакует");
        }
    }
}
