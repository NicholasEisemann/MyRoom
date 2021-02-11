using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MyRoom;

namespace MyRoom.Area
{
    class TheWallArea
    {

        public void Area()
        {
            Program program = new Program();


            Console.WriteLine("Введите наименование комнаты:");
            string room = Console.ReadLine();
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


            string PathFile = @"C:\Users\Seven\OneDrive\Рабочий стол\C#_Project\MyRoom\File\HistorWalls\HistorWalls.txt";


            double SRoom = (WallDouble1 * HeightWall) + (WallDouble2 * HeightWall) + (WallDouble3 * HeightWall) + (WallDouble4 * HeightWall);
            double Windows = NumWindows * (WindowsDouble * HeightWindows);
            double Doors = NumDoors * (DoorsDouble * HeightDoors);
            double SRoomWD = (SRoom - Doors - Windows)/ 100;
            SRoomWD = (double)Math.Round(SRoomWD, 2);


            Console.WriteLine($"Это площадь вашей квартиры - {SRoomWD} m^2" + "\n");


            //сохранение последней работы в историю

            if (File.Exists(PathFile)) //Проверка наличие файла
            {
                File.AppendAllText($"{PathFile}", room + "\n");
                File.AppendAllText($"{PathFile}", "Высота: " + Height + "\n");
                File.AppendAllText($"{PathFile}", "Длина первой стены: " + WallLength1 + "\n");
                File.AppendAllText($"{PathFile}", "Длина второй стены: " + WallLength2 + "\n");
                File.AppendAllText($"{PathFile}", "Длина третьей стены: " + WallLength3 + "\n");
                File.AppendAllText($"{PathFile}", "Длина четвертой стены: " + WallLength4 + "\n");
                File.AppendAllText($"{PathFile}", $"Это площадь вашей квартиры - {SRoomWD} m^2" + "\n" + "\n");
            }

            void Save()
            {
                Console.WriteLine("Желаете ли вы сохранить данные в отдельный документ?  y/n");
                String AddSave = Console.ReadLine();
                if (AddSave == "y")
                {
                    Console.WriteLine("Введите имя файла:");
                    String NameFile = Console.ReadLine();
                    string AddPathFile = @$"C:\Users\Seven\OneDrive\Рабочий стол\C#_Project\MyRoom\File\HistorWalls\{NameFile}.txt";
                    File.Create(AddPathFile).Close();
                    File.AppendAllText($"{AddPathFile}", room + "\n");
                    File.AppendAllText($"{AddPathFile}", "Высота: " + Height + "\n");
                    File.AppendAllText($"{AddPathFile}", "Длина первой стены: " + WallLength1 + "\n");
                    File.AppendAllText($"{AddPathFile}", "Длина второй стены: " + WallLength2 + "\n");
                    File.AppendAllText($"{AddPathFile}", "Длина третьей стены: " + WallLength3 + "\n");
                    File.AppendAllText($"{AddPathFile}", "Длина четвертой стены: " + WallLength4 + "\n");
                    File.AppendAllText($"{AddPathFile}", $"Это площадь вашей квартиры - {SRoomWD} m^2" + "\n" + "\n");
                    Console.WriteLine("Сохранение успешно созданно!");
                    Console.WriteLine();
                    program.Menu();
                }
                else if (AddSave == "n")
                {
                    Console.WriteLine("Хорошо");
                    Console.WriteLine();
                    program.Menu();
                }
                else
                {
                    Console.WriteLine("Не верный ввод");
                    Save();
                }


            }


            Save();
            program.Menu();

        }

        
    }
}
