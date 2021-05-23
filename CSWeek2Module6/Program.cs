using System;

namespace CSWeek2Module6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuOptions = true;
            while (menuOptions)
            {
                menuOptions = Menu(); 
            }

            Console.ReadKey();
             
        }

        private static bool Menu()
        {
            Console.Write("Select Dish:");
            Console.Write("1. Meat");
            Console.Write("2. Chicken");
            Console.Write("3. Fish");

            string option = Console.ReadLine();

            if (option=="1")
            {
                Console.WriteLine("$5.99");

                return true;
            }
            else if (option=="2")
            {
                Console.WriteLine("$4.99");

                return true;
            }
            else if (option=="3")
            {
                Console.WriteLine("3.99");

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
