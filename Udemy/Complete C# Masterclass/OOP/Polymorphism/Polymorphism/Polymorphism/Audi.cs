using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Audi : Car
    {
        private string Brand = "Audi";

        public string Model { get; set; }
        

        public Audi(string model, int hp, string color) : base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("{0} {1} - {2} HP - {3}", Brand, Model, HorsePower, Color);
        }

        public override void Repair()
        {
            Console.WriteLine("{0} {1} has been repaired", Brand, Model);
        }
    }
}
