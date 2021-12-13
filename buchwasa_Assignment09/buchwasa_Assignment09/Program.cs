using System;
using System.Collections.Generic;

namespace buchwasa_Assignment09
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bike> bikes = new List<Bike>();
            Bike bmxBike = new Bike("BMX Bike");

            Console.WriteLine("Time to use my bike");
            bmxBike.OnPower();

            Bike mountainBike = new Bike("Mountain Bike");

            Console.WriteLine("Bob is using his bike");
            mountainBike.OnPower("Bob's bike is now supercharged, he's flying by");

            bikes.Add(bmxBike);
            bikes.Add(mountainBike);

            foreach (Bike bike in bikes)
            {
                Fold(bike);
            }
        }

        static void Fold(Foldable itemToFold)
        {
            Console.WriteLine("Folding to size " + itemToFold.GetFoldSize());
        }
    }
}
