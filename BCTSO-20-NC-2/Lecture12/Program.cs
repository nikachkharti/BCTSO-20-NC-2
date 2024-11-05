namespace Lecture12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array List
            //int[] a = new int[] { 1, 2, 3 };
            //List<int> intlist = new();



            #region STACK LIFO - Last In First Out

            //Stack<int> intStack = new();
            //intStack.Push(1);
            //intStack.Push(2);
            //intStack.Push(3);
            //intStack.Push(4);

            //intStack.Pop();
            //intStack.Pop();
            //intStack.Peek();


            //CheckBalanceOfParentheses("()"); //false

            #endregion


            #region HASHSET

            //HashSet<string> stringSet = new() { "nika", "nika", "daviti" };

            //HashSet<int> intSet = new() { 10, 20, 30 };
            //HashSet<int> intSet2 = new() { 20, 20, 1 };


            //var result = intSet2.IsSubsetOf(intSet);
            //var result = intSet2.IsSupersetOf(intSet);

            //var untiedSets = intSet.Union(intSet2); //გაერთიანება;
            //var commonElements = intSet2.Intersect(intSet2); // საერთო ელემენტები

            #endregion


            #region QUEUE - FIFO First In First Out

            //Queue<int> queue = new();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //var a = queue.Peek();
            //queue.Dequeue();

            #endregion



            #region DICTIONARY

            //Dictionary<string, int> testDictionary = new Dictionary<string, int>();
            //testDictionary.Add("Erti", 1);
            //testDictionary.Add("Ori", 2);
            //testDictionary.Add("Sami", 3);

            //testDictionary.Remove("Erti");
            //var result = testDictionary.Contains(new KeyValuePair<string, int>("Erti", 2));
            //var result = testDictionary.ContainsKey("Ori");
            //var result = testDictionary.ContainsValue(4);

            //testDictionary["Sami"] = 33;

            //foreach (var item in testDictionary)
            //{
            //    Console.WriteLine($"{item.Key} : {item.Value}");
            //}


            var res = CountWordOccurencies("Me var nika me var programisti");
            //["me",2]
            //["var",2]
            //["nika",1]
            //["programisti",1]


            #endregion

        }


        public static Dictionary<string, int> CountWordOccurencies(string text)
        {
            Dictionary<string, int> result = new();
            string[] words = text.Split(' ');

            foreach (var word in words)
            {
                string cleanWord = word.ToLower().Trim();

                if (result.ContainsKey(cleanWord))
                {
                    result[cleanWord]++;
                }
                else
                {
                    result.Add(cleanWord, 1);
                }
            }

            return result;
        }

        public static bool CheckBalanceOfParentheses(string argument)
        {
            Stack<char> stack = new();

            foreach (var character in argument)
            {
                if (character == '(')
                {
                    stack.Push(character);
                }
                else if (character == ')')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }
    }
}
