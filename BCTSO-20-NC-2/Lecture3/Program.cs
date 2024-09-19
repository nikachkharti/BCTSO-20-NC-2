using System.Reflection.PortableExecutable;

namespace Lecture3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FormatException
            //int number = int.Parse("12asda");


            //DivideByZeroException
            //int number1 = 10;
            //int number2 = 0;

            //int result = number1 / number2;

            //try
            //{
            //    int number1 = int.Parse("10");
            //    int number2 = int.Parse("0");

            //    int result = number1 / number2;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("FINALIZER");
            //}


            //int.TryParse("22", out int number1);
            //Console.WriteLine(number1);


            //int x = 10;
            //int y = 20;
            //string name = Console.ReadLine();

            //try
            //{
            //    if (string.IsNullOrEmpty(name))
            //    {
            //        throw new ArgumentNullException();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}



            //ციკლი Loop

            //WHILE
            //int i = 10;
            //while (i > 0)
            //{
            //    Console.WriteLine("NIKA");
            //    i--;
            //}


            //DO WHILE
            //do
            //{
            //    Console.WriteLine("NIKA");
            //}
            //while (true);


            //FOR
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"i: {i}");

            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine($"j: {j}");
            //    }
            //}


            //for (int i = 1; i <= 5; i++)
            //{
            //    if (i == 3)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine($"i: {i}");
            //}

            //FOREACH
            //int[] collection = { 1, 2, 3 };
            //foreach (var item in collection)
            //{
            //    Console.WriteLine(item);
            //}



            //ააწყვეთ კონსოლური კალკულატორი ისე რომ იგი არ წყვეტდეს მუშაობას


            while (true)
            {
                try
                {
                    Console.Write("FIRST NUMBER: ");
                    if (!int.TryParse(Console.ReadLine(), out int firstNumber))
                        continue;

                    Console.Write("SECOND NUMBER: ");
                    if (!int.TryParse(Console.ReadLine(), out int secondNumber))
                        continue;

                    Console.Write("[+  -  *  /]: ");
                    if (!char.TryParse(Console.ReadLine(), out char operation))
                        continue;

                    switch (operation)
                    {
                        case '+':
                            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                            break;
                        case '-':
                            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                            break;
                        case '*':
                            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                            break;
                        case '/':
                            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                            break;
                    }

                    Console.Write("X for exit: ");
                    char.TryParse(Console.ReadLine(), out var exit);

                    if (exit == 'X')
                        break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


        }
    }
}
