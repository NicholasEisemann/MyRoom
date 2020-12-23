using System;
using System.Collections.Generic;
using System.Text;

namespace MyRoom.Area
{
    class TheFloorAndCeiling
    {
        public void FloorAndCeiling()
        {
            Console.WriteLine("Введите длину:");
            string Length = Console.ReadLine();
            float LengthDoub = float.Parse(Length);
            Console.WriteLine("Введите ширину:");
            string Width = Console.ReadLine();
            float WidthDoub = float.Parse(Width);

            float SLAW = LengthDoub * WidthDoub / 100;  //Переменная площади пола или потолка
            SLAW = (float)Math.Round(SLAW, 2);

            Console.WriteLine($"Это площадь ровна - {SLAW} m^2");
        }

    }
}
