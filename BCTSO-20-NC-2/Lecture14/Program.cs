using Algorithms;
using Algorithms.Models;

namespace Lecture14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intAr = { -11, 2, 3, -4 };
            string[] stringAr = { "Nika", "Giorgi", "Giorgi", "Shalva" };

            var x = CustomAlgorithm.OrderBy(stringAr, (a, b) => a.EndsWith('a'));

        }




    }
}
