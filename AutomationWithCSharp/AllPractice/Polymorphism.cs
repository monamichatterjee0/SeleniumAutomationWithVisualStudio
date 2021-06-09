using System;
namespace AutomationWithCSharp.AllPractice
{
    public class Polymorphism
    {
        public static void main()
        {
            Shape objShape = new Shape();
            objShape.displayArea(10, 20);
        }
    }


    public class Shape
    {
        public double area;
        public double pi = 3.14;


        public void displayArea(float radius)
        {


            area = pi * radius * radius;
            Console.WriteLine("Area of a circle is:" + area);

        }

        public void displayArea(int height, int Width)
        {


            area = Convert.ToDouble(height * Width);
            Console.WriteLine("Area of a rectangle is:" + area);
        }
    }
}
