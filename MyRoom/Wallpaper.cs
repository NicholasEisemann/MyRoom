using System;
using System.Collections.Generic;
using System.Text;

namespace MyRoom
{
    class Wallpaper
    {
        void Standart()
        {
            int Width = 53;   //cm
            int Length = 1000;  //сm
        }

        void European()
        {
            int Width = 70;
            int Length = 1000;
        }

        void Meters()
        {
            int Width = 106;
            int Length = 1000;
        }

        void YorsWallpaper()
        {
            Console.WriteLine("Введите ширину рулона");
            string Width = Console.ReadLine();
            int WidthInt = Convert.ToInt32(Width);
            Console.WriteLine("Введите длину рулона");
            string Length = Console.ReadLine();
            int LengthInt = Convert.ToInt32(Length);
        }
    }
}
