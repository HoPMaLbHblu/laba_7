using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_7
{
    internal class Car
    {
        public string? Model;
        public int Speed;
        private int MaxSpeed;
        public Car(string? Model, int MaxSpeed) { this.Model = Model; this.MaxSpeed = MaxSpeed; Speed = 0; }
        public void Accelerate(int delta)
        {
            while (Speed <= MaxSpeed && Speed != delta && delta <= MaxSpeed) { Speed += delta; }
        }
        public void Brake()
        {
            Speed = 0;
        }


    }
}
