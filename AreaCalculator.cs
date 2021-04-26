using System;

namespace CalculatorLibrary
{
    public class AreaCalculator
    {
        public double getSquareArea(int side)
        {
            return side * side;
        }
        public double getSquareArea(string side)
        {
            int number;
            if (side.ToLower() == "one") { number = 1; }
            else if (side.ToLower() == "two") { number = 2; }
            else if (side.ToLower() == "three") { number = 3; }
            else if (side.ToLower() == "four") { number = 4; }
            else if (side.ToLower() == "five") { number = 5; }
            else if (side.ToLower() == "six") { number = 6; }
            else if (side.ToLower() == "seven") { number = 7; }
            else if (side.ToLower() == "eight") { number = 8; }
            else if (side.ToLower() == "nine") { number = 9; }
            else if (side.ToLower() == "ten") { number = 10; }
            else { number = 0; };
            return number * number;
        }
        public double getRectangleArea(int sideA, int sideB)
        {
            return sideA * sideB;
        }
        public double getTriangleArea(int sideA, int sideB)
        {
            return (sideA * sideB) / 2;
        }
        public double getparallelogramArea(int sideA, int sideB)
        {
            return sideA * sideB;
        }
        public double getCircleRadius(int radius)
        {
            double answer = (radius * radius) * Math.PI;
            return Math.Round(answer, 2);
        }
        public double getCircleDiameter(int diameter)
        {
            double radius = diameter / 2;
            double answer = (radius * radius) * Math.PI;
            return Math.Round(answer, 2);
        }
    }
}
