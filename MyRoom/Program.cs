using System;
using MyRoom.Area;

namespace MyRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            // Выбор языка и преветствие

            GreetingClass greetingClass = new GreetingClass();
            TheWallArea theWallArea = new TheWallArea();
            TheFloorAndCeiling theFloorAndCeiling = new TheFloorAndCeiling();

            greetingClass.Greeting();

            // Основной код русской программы
            Console.WriteLine("Какую площадь вы хотите высчитать?");
            Functional();
            string imput = Console.ReadLine();
            if (imput == "Площадь комнаты")
            {
                theWallArea.Area();
            }
            else if (imput == "Площадь пола")
            {
                theFloorAndCeiling.FloorAndCeiling();
            }
            else if (imput == "Площадь потолка")
            {
                theFloorAndCeiling.FloorAndCeiling();
            }    
            else
            {
                Console.WriteLine("Error");
            }



            // Основной функции программы
            void Functional()
            {
                Console.WriteLine();
                Console.WriteLine("Я могу:");
                Console.WriteLine("Измерить площадь пола - Площадь пола");
                Console.WriteLine("Измерить площадь потолка - Площадь потолка");
                Console.WriteLine("Измерить площадь комнаты - Площадь комнаты");
            }

        }
}   }
