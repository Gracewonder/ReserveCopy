using System;
using System.Collections.Generic;
using System.IO;

namespace ReserveCopy
{
    class Uty
    {
        public static void StartCPU(out HDD hdd,out Flash flash, out DVD dvd)
        {
            hdd = new HDD();
            hdd.Chapters = HDD.SetVolume();

            flash = new Flash();
            Console.WriteLine("Введите объём Flash- памяти: ");
            flash.volume = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("1 - односторонний;2 - двусторонний");
            var sides = Convert.ToInt32(Console.ReadLine());
            dvd = new DVD(sides);
        }
        public static string Menu()
        { 
            Console.WriteLine("Резервиная копия");
            Console.WriteLine("****************");
            Console.WriteLine("1- копирование, 2 - Объём памяти, 3 - время копирования, 4 - количество устройств");
            return Console.ReadLine();
        }
        public static string  SelectDevice()
        {
            Console.WriteLine("Выберите устройство для копирования");
            Console.WriteLine("1- HDD, 2 - Flash-память, 3 - DVD");
            return Console.ReadLine();
        }
    }
}
