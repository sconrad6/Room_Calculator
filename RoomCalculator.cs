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

        public double Area() // Calculates area 
        {
            return length * width;
        }

        public double Perimeter() // Calculates perimeter
        {
            return (length * 2) + (width * 2);
        }

        public double Volume(double height) // Calculates volume
        {
            return length * width * height;

        }
       
        public override string ToString() // ToString method to format the area and perimeter 
        {
            return $"Area: {Area()} \nPerimeter: {Perimeter()}";
        }
    }
}
