using System;
using MyRoom.Area; 

namespace MyRoom
{
    public class Program
    {
        static void Main(string[] args)
        {
            TheWallArea theWallArea = new TheWallArea();
            TheFloorAndCeiling theFloorAndCeiling = new TheFloorAndCeiling();
            //Rolls rolls = new Rolls();


            void menu()
            {
                Console.WriteLine("Какую площадь вы хотите высчитать?");
                Functional();
                Console.WriteLine();
                string imput = Console.ReadLine();
                if (imput == "Площадь комнаты")
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

            // Основной функции программы
            void Functional()
            {
                Console.WriteLine();
                Console.WriteLine("Я могу:");
                Console.WriteLine("Измерить площадь пола/потолка - Площадь пола/потолка");
                Console.WriteLine("Измерить площадь комнаты - Площадь комнаты");
            }

            menu();

        }

        TheWallArea theWallArea = new TheWallArea();
        TheFloorAndCeiling theFloorAndCeiling = new TheFloorAndCeiling();
        //Rolls rolls = new Rolls();

        public void Menu()
        {
            Console.WriteLine("Какую площадь вы хотите высчитать?");
            Functional();
            Console.WriteLine();
            string imput = Console.ReadLine();
            if (imput == "Площадь комнаты")
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


            // Основной функции программы
            void Functional()
            {
                Console.WriteLine();
                Console.WriteLine("Я могу:");
                Console.WriteLine("Измерить площадь пола/потолка - Площадь пола/потолка");
                Console.WriteLine("Измерить площадь комнаты - Площадь комнаты");
            }

            Menu();

        }

    }   }
