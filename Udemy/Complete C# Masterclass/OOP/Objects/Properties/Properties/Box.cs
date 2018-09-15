using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Box
    {
        // member variable
        private int length;
        private int height;
        private int width;
        private int volume;
        readonly int surfaceArea;
        
        // auto - implemented property
        public int Width { get; set; }

        public int FrontSurface
        {
            get => length * height;
        }

        public int Length
        {
            get => length;
            set => length = value;
        }

        public int Height {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    value = -value;
                }
                height = value;
            }
        }

        public int Volume
        {
            get
            {
                return Height * Width * Length;
            }
            set
            {
                volume = value;
            }
        }

        // box constuctor
        public Box(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }


        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, width is {2}. Therefore volume is {3}.", Length, Height, Width, volume = Width * Height * Length );
            Console.WriteLine("The front surface of the box is {0}.", FrontSurface );
        }
    }
}
