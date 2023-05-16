using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L10_Interfaces_IEnumerable
{
    internal class TeamRoster : IEnumerable
    {
        // IEnumerable
        // THis interface is what Foreach looks for, in order to loop through it.
        // It's two parts
        List<string> _names;

        public TeamRoster()
        {
            _names = new List<string>();

            _names.Add("Jonathan");
            _names.Add("Cirella");
            _names.Add("Henry");
            _names.Add("Ednalynn");
            _names.Add("Josh");

        }

        // THis was the interface method
        public IEnumerator GetEnumerator()
        {
            // create new instance of your enumerator class
            // pass in the list to loop through
            // return it
            TeamRosterEnumerator tre = new TeamRosterEnumerator(_names);
            return tre;
        }

        // We are going to create an INTERNAL CLASS
        // It will INHERIT from IEnumerator
        // We will do the code to make IEnumerator Work

        private class TeamRosterEnumerator : IEnumerator
        {
            // Fields we need
            // THe current index
            // The list we are working with
            int index = -1;
            List<string> _roster;

            public TeamRosterEnumerator(List<string> roster)
            {
                _roster = roster;
            }

            public object Current => _roster[index];

            public bool MoveNext()
            {
                // We increment the index
                index++;

                // then we check to see if it's past the last item in the list
                if(index >= _roster.Count)
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


            //List<string> _teamRoster;
            //int index = -1;

            //public TeamRosterEnumerator(List<string> teamRoster)
            //{
            //    _teamRoster = teamRoster;
            //}

            //public object Current => _teamRoster[index];

            //public bool MoveNext()
            //{
            //    index++;

            //    if(index >= _teamRoster.Count)
            //    {
            //        return false;
            //    }
            //    else
            //    {
            //        return true;
            //    }
            //}

            //public void Reset()
            //{
            //    index = -1;
            //}

        }
    } // class

} // namespace
