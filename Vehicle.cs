using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L10_Interfaces_IEnumerable
{
    public class Vehicle : IAccelerate
    {
        public Vehicle(int speed, int acceleration)
        {
            Speed = speed;
            Acceleration = acceleration;
        }

        public int Speed { get; set; }
        public int Acceleration { get; set; }

        public void Accelerate()
        {
            Speed += Acceleration;
        }

        public void Stop()
        {
            Speed = 0;
        }

        public override string ToString()
        {
            return $"Current Speed: {Speed}";
        }

    }
}
