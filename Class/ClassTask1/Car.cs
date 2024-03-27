using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask1
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double CurrentFuel { get; set; }
        public double FuelFor1Km { get; set; }
        public double Millage { get; set; }
        public Car(string brand, string model, double currentFuel, double fuelFor1Km, double millage)
        {
            Brand = brand;
            Model = model;
            CurrentFuel = currentFuel;
            FuelFor1Km = fuelFor1Km;
            Millage = millage;
        }

        public void Drive(int km)
        {
            if (CurrentFuel >= FuelFor1Km * km)
            {
                Millage+=km;
                CurrentFuel -= km * FuelFor1Km;
                Console.WriteLine($"Millage:{Millage} Fuel:{CurrentFuel}");
            }
            else
            {
                Console.WriteLine("Kifayet qeder benzin yoxdur");
            }
        }
    }
}
