using CustomAlgorithm;
using System.Linq;

namespace Lecture16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ -- Query -- მოთხოვნა

            //1.Extension მეთოდები
            //2.LINQ Query


            //List<int> intList = new() { 10, 11, 7, 21, 45, 9, 8, 2 };


            //var result = intList
            //    .OrderBy(x => x)
            //    .Where(x => x % 2 != 0)
            //    .LastOrDefault(x => x % 7 == 0);


            //var sortedList = MyAlgorithm.MyOrderBy(intList, (x, y) => x < y);
            //var oddNumbers = MyAlgorithm.MyWhere(sortedList, x => x % 2 != 0);
            //var lastEvenSeven = MyAlgorithm.MyLastOrDefault(oddNumbers, x => x % 7 == 0);


            //var result = intList
            //    .MyOrderBy((x, y) => x < y)
            //    .MyWhere(x => x % 2 != 0)
            //    .MyLastOrDefault(x => x % 7 == 0);

        }
    }
}
