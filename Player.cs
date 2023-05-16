using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L10_Interfaces_IEnumerable
{
    public class Player : IAccelerate
    {
        int _speed;
        int _acclerate;
        int _hp;

        public int Speed { get => _speed; set => _speed = value; }
        public int Acceleration { get => _acclerate; set => _acclerate = value; }
        public int Hp { get => _hp; set => _hp = value; }

        public Player(int speed, int acceleration)
        {
            _speed = speed;
            _acclerate = acceleration;
        }

        public override string ToString()
        {
            return $"Current Speed: {_speed}";
        }

        public void Accelerate()
        {
            Speed += Acceleration;
        }

        public void Stop()
        {
            Speed = 0;
        }
    }
}
