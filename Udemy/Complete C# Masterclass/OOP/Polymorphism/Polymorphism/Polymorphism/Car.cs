using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Car
    {
        public int HorsePower { get; set; }
        public string Color { get; set; }

        // has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("{0} owned by {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }

        public Car()
        {
            HorsePower = 80;
            Color = "green";
        }

        public Car(int hp, string color)
        {
            this.HorsePower = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("{0} HP - {1}", HorsePower, Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired.");
        }
    }
}
