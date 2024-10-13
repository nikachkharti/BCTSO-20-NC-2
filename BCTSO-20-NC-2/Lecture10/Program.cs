namespace Lecture10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Money m1 = new(100, "GEL");
            //Money m2 = new(101, "GEL");


            //CAPACITY - მოცულობა
            // COUNT - რაოდენობა

            //int[] testArray = [199, 188, 2024];

            //List<int> intList = new List<int>();
            //intList.Insert(0, 300);
            //intList.Add(11);
            //intList.Add(121);
            //intList.Add(20);
            //intList.Add(21);
            //intList.Add(23);
            //intList.Clear();
            //intList.Remove(300);
            //intList.RemoveAt(0);
            //intList.Sort();
            //intList.AddRange(testArray);
            //intList.InsertRange(3, testArray);
            //intList.TrimExcess();


            List<string> names = new()
            {
                "Giorgi",
                "Saba",
                "Vazha",
                "Mariami"
            };

            //Money[] moneyArray =
            //{
            //    new Money(10,"EUR"),
            //    new Money(10,"USD"),
            //    new Money(10,"JPY")
            //};


            List<Money> moneyList = new()
            {
                new Money(10, "EUR"),
                new Money(17, "USD"),
                new Money(16, "JPY"),
                new Money(111, "CNY"),
                new Money(126, "GEL")
            };


            //for (int i = 0; i < moneyList.Count; i++)
            //{
            //    Console.WriteLine(moneyList[i]);
            //}


        }



    }
}
