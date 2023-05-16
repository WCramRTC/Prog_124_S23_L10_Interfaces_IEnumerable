using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L10_Interfaces_IEnumerable
{
    internal interface IDecelerate
    {
        public int Speed { get; set; }
        public int Acceleration { get; set; }
        public void Decelerate()
        {
            Speed -= Acceleration;
        }
    }
}
