namespace Lecture2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // არითმეტიკული + - * / %    ++ -- += -= *= /=
            // ლოგიკური > < >= <= == !=
            // შედარების || ან     && და
            // მინიჭების =


            //int number1 = 15;
            //int number2 = 10;


            //switch (number1)
            //{
            //    case int x when x > 1 && x < 4:
            //        Console.WriteLine("AN ORI AN OTXTI");
            //        break;
            //    default:
            //        Console.WriteLine("WADI TAVI DAMANEBE");
            //        break;
            //}


            //if (number1 > 1 && number1 < 4 || number1 ==2 || number1 > 0)
            //{
            //    Console.WriteLine("AN ERTI An ORI AN SAMI");
            //}
            //else if (number1 == 2)
            //{
            //    Console.WriteLine("ORI");
            //}
            //else if (number1 == 3)
            //{
            //    Console.WriteLine("SAMI");
            //}
            //else
            //{
            //    Console.WriteLine("WADI TAVI DAMANEBE");
            //}


            //ლოგიკური
            //Console.WriteLine(number1 == number2);
            //Console.WriteLine(number1 != number2);
            //Console.WriteLine(number1 > number2); 
            //Console.WriteLine(number1 < number2); 
            //Console.WriteLine(number1 >= number2);
            //Console.WriteLine(number1 <= number2);




            //ბინარული
            //Console.WriteLine(number1 + number2);//12
            //Console.WriteLine(number1 - number2);//8
            //Console.WriteLine(number1 * number2);//20
            //Console.WriteLine(number1 / number2); //5
            //Console.WriteLine(number1 % number2); //0


            //არაბინარული
            //Console.WriteLine(number1++);
            ////Console.WriteLine(--number1);
            //Console.WriteLine(number1 += 1);
            //Console.WriteLine(number1 -= 1);
            //Console.WriteLine(number1 *= 1);
            //Console.WriteLine(number1 /= 1);


            //if (number1 > number2)
            //{
            //    Console.WriteLine("METIA");
            //}
            //else if (number1 == number2)
            //{
            //    Console.WriteLine("METIA");
            //}
            //else
            //{
            //    Console.WriteLine("NAKLEBIA");
            //}

            //Console.WriteLine("First Name");
            //string firstName = Console.ReadLine();

            //Console.WriteLine("Last Name");
            //string lastName = Console.ReadLine();

            //Console.WriteLine("Age");
            ////byte age = byte.Parse(Console.ReadLine());
            //byte age = Convert.ToByte(Console.ReadLine());


            ////IMPLICIT CAST  არაცხადი გადაყვანა
            //byte x = 10;
            //int y = x;


            //EXPLICIT CAST  ცხადი გადაყვანა
            int x = 10;
            byte y = (byte)x;

            Console.WriteLine($"X: {x} Y: {y}");
        }
    }
}
