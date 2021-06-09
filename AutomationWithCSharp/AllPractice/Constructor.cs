using System;
namespace AutomationWithCSharp.AllPractice
{ 

    public class parameterizedContructor
    {
        int num;

        public parameterizedContructor(int i)
        {
            this.num = i;
        }

        public void findNumberEvenOdd()
        {
          if (num >0 && num % 2 == 0)
            {
                Console.Write("Even num");
            }
            else
            {
                Console.Write("Odd num");
            }
        }
    }
}
