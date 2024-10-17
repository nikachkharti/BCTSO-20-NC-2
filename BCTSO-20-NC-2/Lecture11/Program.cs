using Algorithms.Models;
using Algorithms;


namespace Lecture11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] stringVehicles = File.ReadAllLines(@"../../../vehicles.csv");

            Vehicle[] vehicles = Select(stringVehicles);
            Vehicle[] sortedVehicles = Sort(vehicles);
            Vehicle[] tenMostEconmicCars = Take(vehicles);

            List<Vehicle> mercedeses = CustomAlgorithm.Where(vehicles, "mercedes");

        }

        private static Vehicle[] Take(Vehicle[] vehicles)
        {
            Vehicle[] tenMostEconomicCars = new Vehicle[10];
            for (int i = 0; i < tenMostEconomicCars.Length; i++)
            {
                tenMostEconomicCars[i] = vehicles[i];
            }

            return tenMostEconomicCars;
        }

        private static Vehicle[] Sort(Vehicle[] vehicles)
        {
            for (int i = 0; i < vehicles.Length - 1; i++)
            {
                for (int j = i + 1; j < vehicles.Length; j++)
                {
                    if (vehicles[j].Combined > vehicles[i].Combined)
                    {
                        Vehicle temp = vehicles[j];
                        vehicles[j] = vehicles[i];
                        vehicles[i] = temp;
                    }
                }
            }

            return vehicles;
        }

        private static Vehicle[] Select(string[] stringVehicles)
        {
            Vehicle[] vehicles = new Vehicle[stringVehicles.Length];
            for (int i = 0; i < stringVehicles.Length; i++)
            {
                vehicles[i] = Vehicle.Parse(stringVehicles[i]);
            }

            return vehicles;
        }
    }
}
