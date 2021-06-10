using System;
namespace AutomationWithCSharp.AllPractice
{
    public class MethodOverRiding
    { 

        public virtual void testingOverriding(int width, int height)
        {
            Console.Write("Base class area of rectangle: {0} {0}" + width * height);

        }
    }

    public class childClass: MethodOverRiding
    {

        

        public override void testingOverriding(int width, int height)
        {
            Console.Write("Child class area of rectangle: " + width * height);
        }
    }
}
