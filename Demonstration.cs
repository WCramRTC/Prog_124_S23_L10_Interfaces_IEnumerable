using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L10_Interfaces_IEnumerable
{
    internal class Demonstration : IEnumerable
    {
        List<string> _displayList;

        public Demonstration()
        {
            _displayList = new List<string>();

            _displayList.Add("Will");
            _displayList.Add("Josh");
            _displayList.Add("Sam");
            _displayList.Add("Frank");
            _displayList.Add("Ringo");
            _displayList.Add("Bort");

        } // Demonstration()

        public IEnumerator GetEnumerator()
        {
            return new EnumeratorHelp(_displayList);
        }

        class EnumeratorHelp : IEnumerator
        {
            public object Current => _students[index];
            int index = -1;
            List<string> _students;

            public EnumeratorHelp(List<string> list)
            {
                _students = list;
            }

            public

            bool MoveNext()
            {
                index++;

                if(index >= _students.Count)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
