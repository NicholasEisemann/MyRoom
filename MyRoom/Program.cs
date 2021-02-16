using System;
using MyRoom.Area;

namespace MyRoom
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyMenu myClass = new MyMenu();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Главное Меню");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Я могу:");
            Console.WriteLine("Измерить площадь пола/потолка - Площадь пола/потолка");
            Console.WriteLine("Измерить площадь стен - Площадь Стен");
            Console.WriteLine();
            myClass.Menu();

        }

    }

    public class MyMenu
    {
        public void Menu()
        {
            TheWallArea theWallArea = new TheWallArea();
            TheFloorAndCeiling theFloorAndCeiling = new TheFloorAndCeiling();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Какую площадь вы хотите высчитать?");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            string imput = Console.ReadLine();
            if (imput == "Площадь Стен")
            {
                theWallArea.Area();
            }
            else if (imput == "Площадь пола/потолка")
            {
                theFloorAndCeiling.FloorAndCeiling();
            }
            else
            {
                Console.WriteLine("Error");
            }

        }

    }
}

