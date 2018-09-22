using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class BMW : Car
    {
        private string Brand = "BMW";

        public string Model { get; set; }

        public BMW(string model, int hp, string color): base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("{0} {1} - {2} HP - {3}", Brand, Model, HorsePower, Color);
        }

        public sealed override void Repair()
        {
            Console.WriteLine("{0} {1} has been repaired", Brand, Model);
        }
    }
}
