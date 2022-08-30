using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carclass
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public bool Petrol { get; set; }
        public string Transmition { get; set; }


        public Car()
        {

        }

        public Car(string bran, string mode, string col, bool pet, string trans)
        {
            Brand = bran;
            Model = mode;
            Color = col;
            Petrol = pet;
            Transmition = trans;
        }
    }
}
