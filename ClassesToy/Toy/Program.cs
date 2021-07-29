using System;
using System.Collections.Generic;

namespace Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toys = new List<string>();
            
            Toy toy1 = new Toy();
            toy1.Manufacturer = "Walter Camp";
            toy1.Name = "Football";
            toy1.Price = 19.99;
            string aisleNumber1 = toy1.GetAisle();

            Toy toy2 = new Toy();
            toy2.Manufacturer = "Jeffrey Nightengale";
            toy2.Name = "Baseball";
            toy2.Price = 5.00;
            string aisleNumber2 = toy2.GetAisle();

            Console.WriteLine($"{toy1.Name} was created by {toy1.Manufacturer} with a " +
                $"price of {toy1.Price.ToString("C2")} and can be found in aisle {aisleNumber1.ToString()}.");
            Console.WriteLine();
            Console.WriteLine($"{toy2.Name} was created by {toy2.Manufacturer} with a " +
                $"price of {toy2.Price.ToString("C2")} and can be found in aisle {aisleNumber2.ToString()}.");
            
        }
    }
}
