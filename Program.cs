namespace Prog_124_S23_L10_Interfaces_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demonstration demo = new Demonstration();

            //foreach (string d in demo)
            //{
            //    Console.WriteLine(d);
            //}

            // Interfaces, how to implement, why we use them,
            // IEnumerable and IEnumerator

            // and interface is a way for two seperate systems to interact with one another

            List<IAccelerate> _canMove = new List<IAccelerate>();

            _canMove.Add(new Player(10, 5));
            _canMove.Add(new Vehicle(12, 4));
            _canMove.Add(new Rock(12, 4));

            //foreach (IAccelerate accel in _canMove)
            //{
            //    accel.
            //}
            TeamRoster tr = new TeamRoster();

            foreach (string item in tr)
            {
                Console.WriteLine(item);
            }



        }
    }
}