using System;
namespace AutomationWithCSharp.AllPractice
{
    public class HumanInheritenceExample
    {
        public String bodyStructure;
        public String type;
        public bool hasPet;

        public void humanCanStudy()
        {
            Console.Write("All human needs to eat");
        }

        protected void humanBreadth()
        {
            Console.Write("All human needs to bradth");
        }


    }

    public class engineer: HumanInheritenceExample
    {
        public string degree;

        public void study()
        {
            Console.Write("Engineer Study B.tech");
        }
    }

    public class CivilEngineer: engineer
    {

        public string Work;

        public void whereToWork()
        {
            Console.Write("Construction work");
        }
    }
}
