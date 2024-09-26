using System.Collections;
using System.Text;

namespace Lecture5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Single responsibility

            #region HIDE
            //int[] collection = { 1, -2 };
            //int[] negativeNumbers = new int[1];

            //for (int i = 0; i < collection.Length; i++)
            //{
            //    if (collection[i] < 0)
            //    {
            //        negativeNumbers[i] = collection[i];
            //    }
            //}


            //for (int i = 0; i < negativeNumbers.Length; i++)
            //{
            //    Console.WriteLine(negativeNumbers[i]);
            //} 
            #endregion

            //Console.Write("FirstName: ");
            //string firstName = Console.ReadLine();

            //Console.Write("LastName: ");
            //string lastName = Console.ReadLine();

            //Console.Write("Age: ");
            //int.TryParse(Console.ReadLine(), out int age);

            //Console.Write("[F] [C]");
            //char.TryParse(Console.ReadLine(), out char operation);


            //switch (operation)
            //{
            //    case 'F':
            //        WriteDataInFile($"{firstName} {lastName} {age}");
            //        break;
            //    case 'C':
            //        WriteDataInConsole($"{firstName} {lastName} {age}");
            //        break;
            //}

            //int[] intArray = [1, 10, 100];
            //var lastElementOfArray = LastElement(intArray);


            //string firstText = "nika chkharti shvili";
            //string secondText = "Nika Chkhartishvili";

            //var result = string.Compare(firstText, secondText, ignoreCase: true);  //-1   0   1
            //var result = firstText.CompareTo(secondText);

            //Console.WriteLine("test text".ToLower());
            //Console.WriteLine("test text".ToUpper());

            //var result = firstText.ToLower() == secondText.ToLower();
            //var result = firstText.ToLower().Equals(secondText);

            //var result = firstText.Contains("za");

            //char[] result = firstText.Concat("asasdasdasd").ToArray();

            //var result = firstText.Insert(1,"TEST");
            //Console.WriteLine(firstText.EndsWith("I",StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(firstText.StartsWith("I",StringComparison.OrdinalIgnoreCase));

            //char[] tests = new char[12];
            //firstText.CopyTo(0, tests, 3, 5);
            //Console.WriteLine(firstText.IndexOf('n'));
            //Console.WriteLine(firstText.LastIndexOf('n'));
            //string changedText = firstText.Replace("a","jemali");
            //var x = secondText.Substring(1, secondText.Length-1);
            //var x = firstText.Trim();
            //var x = firstText.TrimStart();
            //var x = firstText.TrimEnd();
            //string[] separatedText = firstText.Split(' ', 'i');


        }

        //static int LastElement(int[] intCollection)
        //{
        //    return intCollection[intCollection.Length - 1];
        //}
        //static string LastElement(string[] intCollection)
        //{
        //    return intCollection[intCollection.Length - 1];
        //}
        //static char LastElement(char[] intCollection)
        //{
        //    return intCollection[intCollection.Length - 1];
        //}
        //static double LastElement(double[] intCollection)
        //{
        //    return intCollection[intCollection.Length - 1];
        //}


        //static void WriteDataInFile(string message) => File.WriteAllText(@"../../../TestData.txt", message);
        //static void WriteDataInConsole(string message) => Console.WriteLine(message);


        //static int Sum(int firstValue, int secondValue)
        //{
        //    int result = 50 + 20;
        //    return result;
        //}



    }



}