using System;

namespace ReserveCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Uty.StartCPU(out HDD hdd, out Flash flash, out DVD dvd);

            double freeVolumeFlash = flash.volume;
            double freeVolumeDvd = dvd.GetVolume();
            double freeVolumeHdd = hdd.GetVolume();
        var copyInfo = 565.0;//Gb
            var files = 725;

            var select = Uty.Menu();
            var device = Uty.SelectDevice();
            if (select == "1'")
            { 
                switch (device)
                {
                    case "1":
                        {
                            hdd.Copy(files);
                            Console.WriteLine($"{ hdd.GetVolume()}");
                            Console.WriteLine($"{ hdd.Chapters.Count}");

                        }
                        break;
                    case "2":
                        {
                            flash.Copy(files);
                            freeVolumeFlash -= flash.GetVolume();
                        }
                        break;
                    case "3":
                        {
                            dvd.Copy(files);
                            freeVolumeDvd -= dvd.GetVolume();
                        }
                        break;
                }
            }else if(select=="3")
            {
                Console.Write("Время копирования на жёсткий диск: ");
                Console.Write((copyInfo / hdd.speed) / 60);
                Console.WriteLine("минут");
                Console.Write("Время копирования на жёсткий диск: ");
                Console.Write((copyInfo / flash.speed) / 60);
                Console.WriteLine("минут");
                Console.Write("Время копирования на жёсткий диск: ");
                Console.Write((copyInfo / dvd.speed) / 60);
                Console.WriteLine("минут");
            }
            else if(select=="2")
            {
                Console.WriteLine($"Свободная память на жёстком диске{freeVolumeHdd}");
                Console.WriteLine($"Свободная память на flash-накопителе{freeVolumeFlash}");
                Console.WriteLine($"Свободная память на жёсткомDVD-диске{freeVolumeDvd}");
            }else if(select=="4")
            {
                Console.WriteLine($"Требуется {copyInfo} Гб свободного места на жёстком диске");
                Console.WriteLine($"Требуется {copyInfo/ flash.volume} накопителей данного типа");
                Console.WriteLine($"Требуется {copyInfo / dvd.GetVolume()} DVD дисков данного типа");
            }
        }
    }
}
