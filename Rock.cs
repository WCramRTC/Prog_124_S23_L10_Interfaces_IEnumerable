using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L10_Interfaces_IEnumerable
{
    public class Rock : IAccelerate
    {
        int _speed;
        int _acceleration;

        public Rock(int speed, int acceleration)
        {
            _speed = speed;
            _acceleration = acceleration;
        }

        public int Speed { get => _speed; set => _speed = value; }
        public int Acceleration { get => _acceleration; set => _acceleration = value; }

        // Making a single method, called Accelerate
        public void Accelerate()
        {
            _speed += _acceleration;
        }


        public void Stop()
        {
            Speed = 0;
        }

        public override string ToString()
        {
            return $"Current Speed: {_speed}";
        }
    }
}
