using System;
using System.Collections.Generic;
using System.Text;

namespace ReserveCopy
{
    class HDD : Storage
    {
        public List<int> Chapters;
        public override double GetVolume()
        {
            var sum = 0;
            for (var i=0;i<Chapters.Count;i++)
            {
                sum += Chapters[i];
            }
            return sum;
        }
        
        public HDD()
        {
            title = "Toshiba";
            model = "114M9064";
            speed = 0.48;//480Mb\s
            Chapters = new List<int>();
        }
        public static List<int> SetVolume()
        {
            List<int> nums = new List<int>();
            string choice;
            int num;
            
            do
            {
                Console.WriteLine("1 - добавить раздел; 0 - выйти");
                choice = Console.ReadLine();
                Console.WriteLine("Введите объём памяти следующего раздела: __Гб");
                num = Convert.ToInt32(Console.ReadLine());
                nums.Add(num);
            } while (choice != "0");
            return nums;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Устройство: {title}");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Объём памяти: {GetVolume()} Gbs");
            Console.WriteLine($"Скорсть записи: {speed} Mbs/s");
            Console.WriteLine($"Количество раделов: {Chapters.Count}");
        }
        public override void Copy(int filecopy)
        {
            int countFiles=0;

            for(var i=0;i<Chapters.Count;i++)
            {
                countFiles += Convert.ToInt32(Chapters[i] / 0.78);
            }

            if (filecopy - countFiles > 0)
            {
                Console.WriteLine("Недостаточно места на дисках");
            }else 
            { 
                Console.WriteLine("Копирование завершено"); 
            }

            countFiles = 0;

            for (var i = 0; i < Chapters.Count; i++)
            {
                countFiles += Convert.ToInt32(Chapters[i] / 0.78);

                Chapters[i] -= Convert.ToInt32(countFiles * 0.78);
            }
        }
    }
}
