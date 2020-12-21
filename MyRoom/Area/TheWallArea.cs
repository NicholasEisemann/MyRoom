using System;
using System.Collections.Generic;
using System.Text;

namespace MyRoom.Area
{
    public class TheWallArea
    {

        public void Area()
        {
            Console.WriteLine("Укажите размер комнаты");

            double WallDouble1;
            double WallDouble2;
            double WallDouble3;
            double WallDouble4;


            // Стена №1
            Console.WriteLine("Стена №1:");
            Console.WriteLine("Длина:");
            string WallLength1 = Console.ReadLine();
            WallDouble1 = Convert.ToDouble(WallLength1);
            Console.WriteLine("Высота:");
            string Height = Console.ReadLine();
            double HeightWall = Convert.ToDouble(Height);

            // Стена №2
            Console.WriteLine("Стена №2:");
            Console.WriteLine("Длина:");
            string WallLength2 = Console.ReadLine();
            WallDouble2 = Convert.ToDouble(WallLength2);

            // Стена №3
            Console.WriteLine("Стена №3:");
            Console.WriteLine("Длина:");
            string WallLength3 = Console.ReadLine();
            WallDouble3 = Convert.ToDouble(WallLength3);

            // Стена №4
            Console.WriteLine("Стена №4:");
            Console.WriteLine("Длина:");
            string WallLength4 = Console.ReadLine();
            WallDouble4 = Convert.ToDouble(WallLength4);

            // Окна - The Windows
            Console.WriteLine("Колличество Окон:");
            string NumWin = Console.ReadLine();
            double NumWindows = Convert.ToDouble(NumWin); 
            Console.WriteLine("Длина:");
            string WindowsLength = Console.ReadLine();
            double WindowsDouble = Convert.ToDouble(WindowsLength);
            Console.WriteLine("Высота:");
            string HeightWin = Console.ReadLine();
            double HeightWindows = Convert.ToDouble(HeightWin);

            // Двери - The Doors
            Console.WriteLine("Колличество Дверей:");
            string NumDoor = Console.ReadLine();
            double NumDoors = Convert.ToDouble(NumDoor);
            Console.WriteLine("Длина:");
            string DoorsLength = Console.ReadLine();
            double DoorsDouble = Convert.ToDouble(DoorsLength);
            Console.WriteLine("Высота:");
            string HeightDoor = Console.ReadLine();
            double HeightDoors = Convert.ToDouble(HeightDoor);

          
            double SRoom = (WallDouble1 * HeightWall) + (WallDouble2 * HeightWall) + (WallDouble3 * HeightWall) + (WallDouble4 * HeightWall);
            double Windows = NumWindows * (WindowsDouble * HeightWindows);
            double Doors = NumDoors * (DoorsDouble * HeightDoors);
            double SRoomWD = (SRoom - Doors - Windows)/ 100;


            Console.WriteLine($"Это площадь вашей квартиры - {SRoomWD} m^2");


        }
        

    }
}
