using CustomAlgorithm;

namespace Lecture15
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new() { 1, 2, 4 };
            int[] intAr = { 10, 203, 30 };
            HashSet<int> intSet = new() { 1, 2, 1, 3 };
            Dictionary<int, string> intStringDic = new();
            intStringDic[0] = "zero";
            intStringDic[1] = "erti";
            intStringDic[2] = "erti";

            var x = MyAlgorithm.MySelect(intList, x => x.ToString());

        }



    }
}
