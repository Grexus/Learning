using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class M3 : BMW
    {

        public M3(string model, int hp, string color) : base(model, hp, color)
        {
            this.Model = model;
        }
    }
}
