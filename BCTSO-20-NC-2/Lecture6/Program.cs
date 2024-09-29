namespace Lecture6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = [10, 3, 5, 2, 10, 12, 66, 10];

            //FindAll(10) => (10,10,10)

        }







        public static int[] Sort(int[] collection)
        {
            for (int i = 0; i < collection.Length - 1; i++)
            {
                for (int j = i + 1; j < collection.Length; j++)
                {
                    if (collection[j] < collection[i])
                    {
                        int temp = collection[j];
                        collection[j] = collection[i];
                        collection[i] = temp;
                    }
                }
            }

            return collection;
        }


        //არასწორი გზა ესე არ წეროთ!!!
        //public static Tuple<int, int> CountEvenAndOddElements(int[] collection)
        //{
        //    int oddResult = 0;
        //    int evenResult = 0;

        //    for (int i = 0; i < collection.Length; i++)
        //    {
        //        if (collection[i] % 2 == 0)
        //        {
        //            evenResult++;
        //        }
        //        else
        //        {
        //            oddResult++;
        //        }
        //    }

        //    return Tuple.Create(oddResult, evenResult);
        //}

        public static int CountEvenElements(int[] collection)
        {
            int result = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] % 2 == 0)
                {
                    result++;
                }
            }

            return result;
        }
        public static int CountOddElements(int[] collection)
        {
            int result = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] % 2 != 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
