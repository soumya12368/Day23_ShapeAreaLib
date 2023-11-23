using System;
namespace ShapeAreaLib
{
    public class Rectangle
    {
        public double CalculateArea(double length, double width)
        {
            return length * width;
        }
        public class Square
        {
            public double CalculateArea(double side)
            {
                return side * side;
            }
        }
        public class circle
        {
            public double CalculateArea(double radius)
            {
                return Math.PI * radius * radius;
            }
        }
    }
    public class Triangle
    {
        public double CalculateArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }
    }
}

