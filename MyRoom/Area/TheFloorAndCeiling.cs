using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MyRoom.Area
{
    class TheFloorAndCeiling
    {
        public void FloorAndCeiling()
        {
            Console.WriteLine("Введите наименование комнаты:");
            string room = Console.ReadLine();
            Console.WriteLine("Введите длину:");
            string Length = Console.ReadLine();
            float LengthDoub = float.Parse(Length);
            Console.WriteLine("Введите ширину:");
            string Width = Console.ReadLine();
            float WidthDoub = float.Parse(Width);

            string PathFile = @"C:\Users\Seven\OneDrive\Рабочий стол\C#_Project\MyRoom\File\HistorFloors-Ceilings\HistorFloors-Ceilings.txt";

            float SLAW = LengthDoub * WidthDoub / 100;  //Переменная площади пола или потолка
            SLAW = (float)Math.Round(SLAW, 2);

            Console.WriteLine($"Это площадь пола/потолка - {SLAW} m^2");

            Console.WriteLine("Желаете ли вы сохранить данные в отдельный документ?  y/n");
            String AddSave = Console.ReadLine();
            Console.WriteLine("Введите имя файла:");
            String NameFile = Console.ReadLine();
            string AddPathFile = @$"C:\Users\Seven\OneDrive\Рабочий стол\C#_Project\MyRoom\File\HistorFloors-Ceilings\{NameFile}.txt";

            if (AddSave == "y")
            {
                File.Create(AddPathFile).Close();
                File.AppendAllText($"{AddPathFile}", room + "\n");
                File.AppendAllText($"{AddPathFile}", "Длина: " + Length + "\n");
                File.AppendAllText($"{AddPathFile}", "Ширина: " + Width + "\n");
                File.AppendAllText($"{AddPathFile}", $"Площадь пола/потолка: {SLAW} m^2" + "\n" + "\n");
                Console.WriteLine("Сохранение успешно созданно!");
            }
            else
            {
                Console.WriteLine("Хорошо");
            }


            if (File.Exists(PathFile)) //Проверка наличие файла
            {
                File.AppendAllText($"{PathFile}", room + "\n");
                File.AppendAllText($"{PathFile}", "Длина: " + Length + "\n");
                File.AppendAllText($"{PathFile}", "Ширина: " + Width + "\n");
                File.AppendAllText($"{PathFile}", $"Площадь пола/потолка: {SLAW} m^2" + "\n" + "\n");
            }

            Console.ReadKey();

        }

    }
}
