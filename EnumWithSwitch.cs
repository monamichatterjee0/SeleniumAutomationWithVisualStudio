using System;
namespace AutomationWithCSharp.AllPractice
{
    public enum places { India, USA, Africa, Japan, Europe };

    public class EnumWithSwitch
    {

        public void checking()
        {
            int value = Convert.ToInt32(places.India);

            switch (value)
            {
                case 0:
                    Console.Write("India");

                    break;

                case 1:
                    Console.Write("USA");

                    break;

                case 2:
                    Console.Write("Africa");

                    break;


                case 3:
                    Console.Write("Japan");

                    break;

                case 4:
                    Console.Write("Europe");

                    break;

                default:
                    Console.Write("Other Contries");
                    break;




            }
        }

        

       
        

}

    }

