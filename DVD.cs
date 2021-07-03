using System;
using System.Collections.Generic;
using System.Text;

namespace ReserveCopy
{
    class DVD : Storage
    {
        public int Sides { get; set; }//one or two sides 4.7/9 Gb
        protected double _volume { get; set; }
        public double volume
        {
            get { return _volume; }
            set { _volume = value; }
        }
        public override double GetVolume()
        {
            return _volume*Sides;
        }
        public DVD (int parts)
        {
            volume=4.5;
            title = "Pleomax";
            model = "DVD-RW";
            speed = 11.08/1000;//8X1.385Mb/s=11.08Mb/s
            Sides= parts;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Устройство: {title}");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Объём памяти: {volume} Gbs");
            Console.WriteLine($"Скорсть записи: {speed} Mbs/s");
            Console.WriteLine($"Количество сторон: {Sides}");
        }
        public override void Copy(int filesCopy)
        {
            int countFiles = Convert.ToInt32(GetVolume() / 0.78);
            if (filesCopy - countFiles > 0)
            {
                Console.WriteLine("Недостаточно места на диске");
            }
            else
            {
                Console.WriteLine("Копирование завершено");
                volume -= Convert.ToDouble(countFiles);
            }
        }
    }
}
