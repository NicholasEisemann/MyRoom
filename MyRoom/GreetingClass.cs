using System;
using System.Collections.Generic;
using System.Text;

namespace MyRoom
{
    class GreetingClass
    {
        public void Greeting()
        {

            Console.WriteLine("Eng or Rus ?");
            string input = Console.ReadLine();

            if (input == "Eng")
            {
                Console.WriteLine("Welcome the programm - MyRoom");
            }
            else if (input == "Rus")
            {
                Console.WriteLine("Вас приветствует помощник программы MyRoom");
            }
            else
            {
                Console.WriteLine("Error");
            }


        }






    }
}