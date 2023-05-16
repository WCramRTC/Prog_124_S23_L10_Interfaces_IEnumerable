namespace Prog_124_S23_L10_Interfaces_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demonstration demo = new Demonstration();

            foreach (string d in demo)
            {
                Console.WriteLine(d);
            }
        }
    }
}