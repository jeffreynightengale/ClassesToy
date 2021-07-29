using System;
using System.Collections.Generic;
using System.Text;

namespace Toy
{
    class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Notes;

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            List<string> Notes = new List<string>();
        }

        public string GetAisle()
        {
            Random rand = new Random();
            int randomNum = rand.Next(1, 25);

            string aisleNumber = $"{Manufacturer[0]}{randomNum}";
            return aisleNumber;
        }
    }
}
