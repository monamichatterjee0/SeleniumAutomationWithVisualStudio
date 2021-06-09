using System;
namespace AutomationWithCSharp.AllPractice
{
    public class SwitchCase
    {
        public String value;
        public float width;
        public float height;
        public int side;


        public void areaCalculation(string value, float width, float height, int side)
        {

           
            switch (value)
            {
                case "square":
                    float areaOfSquare = side * side;
                    Console.WriteLine("Area of a square is: " + areaOfSquare);
                    break;

                case "rectangle":
                    float areaOfRectangle = height * width;
                    Console.WriteLine("Area of a rectangle is: " + areaOfRectangle);
                    break;

                default:
                    Console.WriteLine("Other Area");
                    break;
            }

        }
    }
}
