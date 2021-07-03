using System;
using System.Collections.Generic;
using System.Text;

namespace ReserveCopy
{
    class Flash : Storage
    {
        
        public int volume {get;set;}
        public override double GetVolume()
        {
            return  volume;
        }
        public Flash()
        {
            title = "Kingstone";
            model = "F380NT";
            speed=5;//Mb"(5Gb/s
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Устройство: {title}");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Объём памяти: {volume}");
            Console.WriteLine($"Скорсть записи: {speed}");
        }
        public override void Copy(int filesCopy)
        {
            int countFiles =Convert.ToInt32(volume/0.78) ;
            
            if(filesCopy - countFiles > 0)
            {
                Console.WriteLine("Недостаточно места на диске");
            }else
            {
                Console.WriteLine("Копирование завершено");
                volume -= countFiles;
            }
        }
    }

    
}
