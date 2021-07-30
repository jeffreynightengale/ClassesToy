using System;
using System.Collections.Generic;

namespace Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy toy1 = new Toy();
            toy1.Manufacturer = "Walter Camp";
            toy1.Name = "Football";
            toy1.Price = 19.99;
            string aisleNumber1 = toy1.GetAisle();
            toy1.GettingNotes("Great for all ages.");
            

            Toy toy2 = new Toy();
            toy2.Manufacturer = "Jeffrey Nightengale";
            toy2.Name = "Baseball";
            toy2.Price = 5.00;
            string aisleNumber2 = toy2.GetAisle();
            toy2.GettingNotes("Great with having fun with child.");

            Console.WriteLine($"{toy1.Name} was created by {toy1.Manufacturer} with a " +
                $"price of {toy1.Price.ToString("C2")} and can be found in aisle {aisleNumber1.ToString()}.");
            Console.WriteLine($"The notes for toy 1 are: {toy1.ReturningNotes()}");

            Console.WriteLine();

            Console.WriteLine($"{toy2.Name} was created by {toy2.Manufacturer} with a " +
                $"price of {toy2.Price.ToString("C2")} and can be found in aisle {aisleNumber2.ToString()}.");
            Console.WriteLine($"The notes for toy 2 are: {toy2.ReturningNotes()}");
            
        }
    }
}
