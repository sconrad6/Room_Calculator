using System;

namespace Room_Calculator
{
    class RoomCalculator
    {
        private readonly double length;
        private readonly double width;

        public RoomCalculator()
        {
            length = 0;
            width = 0;
        }

        public RoomCalculator(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double Area()
        {
            return length * width;
        }

        public double Perimeter()
        {
            return (length * 2) + (width * 2);
        }

        public double Volume(double height)
        {
            return length * width * height;

        }
       
        public override string ToString()
        {
            return $"Area: {Area()} \nPerimeter: {Perimeter()}";
        }
    }
}
