using Algorithms.Models;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new() { 1, 2, 3, 3, 7, 21 };
            var carsData = File.ReadAllLines("C:\\Users\\User\\Desktop\\IT STEP\\BCTSO-20-NC-2\\BCTSO-20-NC-2\\Lecture11\\vehicles.csv");
            var cars = CustomAlgorithm.Select(carsData, Parse);

            var sortedCars = CustomAlgorithm.OrderBy(cars,CompareTwoVehicles);


        }

        public static bool CompareTwoVehicles(Vehicle v1, Vehicle v2)
        {
            if (v1.Combined > v2.Combined)
            {
                return true;
            }

            return false;
        }

        public static Vehicle Parse(string data)
        {
            return Vehicle.Parse(data);
        }
        public static bool FindBMWs(Vehicle vehicle)
        {
            if (vehicle.Make.Trim().ToLower() == "BMW".Trim().ToLower())
            {
                return true;
            }

            return false;
        }
        public static bool NumberDividesToSeven(int number)
        {
            if (number % 7 == 0)
            {
                return true;
            }

            return false;
        }
        public static bool NumberIsNegative(int number)
        {
            if (number > 0)
            {
                return true;
            }

            return false;
        }
        public static bool NumberIsPositive(int number)
        {
            if (number > 0)
            {
                return true;
            }

            return false;
        }
        public static bool NumberIsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }

            return false;
        }
        public static bool NumberIsOdd(int number)
        {
            if (number % 2 != 0)
            {
                return true;
            }

            return false;
        }

    }
}
