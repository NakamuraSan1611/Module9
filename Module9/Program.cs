using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доступные типы устройств HDD, DVD, USB Flash");

            Console.WriteLine("Введите инфу для HDD");
            Console.WriteLine("Введите имя HDD");
            string nameHDD = Console.ReadLine();
            Console.WriteLine("Введите модель HDD");
            string modelHDD = Console.ReadLine();
            Console.WriteLine("Введите объем HDD в мегах");
            double capacityHDD = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип HDD (2.0 или 3.0)");
            string typeHDD = Console.ReadLine();
            HDD hdd = new HDD(nameHDD, modelHDD, capacityHDD, typeHDD);
            //о гспди опять
            Console.WriteLine("Введите инфу для DVD");
            Console.WriteLine("Введите имя DVD");
            string nameDVD = Console.ReadLine();
            Console.WriteLine("Введите модель DVD");
            string modelDVD = Console.ReadLine();
            Console.WriteLine("Введите тип DVD (one side или double side)");
            string typeDVD = Console.ReadLine();
            DVD DVD = new DVD(nameDVD, modelDVD, typeDVD);

            Console.WriteLine("Введите инфу для Flash");
            Console.WriteLine("Введите имя Flash");
            string nameFlash = Console.ReadLine();
            Console.WriteLine("Введите модель Flash");
            string modelFlash = Console.ReadLine();
            Console.WriteLine("Введите объем Flash в мегах");
            double capacityFlash = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип Flash (2.0 или 3.0)");
            string typeFlash = Console.ReadLine();
            Flash Flash = new Flash(nameFlash, modelFlash, capacityFlash, typeFlash);
            Console.WriteLine("жмяк любую");
            Console.ReadKey();
            Console.Clear();
            //●	расчет общего количества памяти всех устройств;
            Console.WriteLine("Общее количество всей памяти " +
                "{0}", DVD.getCapacity() + hdd.getCapacity() + Flash.getCapacity());

            //●	копирование информации на устройства;
            //●	расчет времени необходимого для копирования;

            while (true)
            {
                Console.WriteLine("Выберите какой файл копировать за раз 565 Gb или 780 " +
                       "Mb в мегах (565000 или 780, ну или хоть че, адекватное)");
                double file = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите тип носителя (HDD, DVD, Flash) для " +
                    "копирования и расчета времени, (break для продолжения)");
                string type = Console.ReadLine();
                if (type == "HDD")
                    Console.WriteLine("затраченное время {0} секунд", hdd.copyData(file));
                else
                if (type == "DVD")
                    Console.WriteLine("затраченное время {0} секунд", DVD.copyData(file));
                else
                if (type == "Flash")
                    Console.WriteLine("затраченное время {0} секунд", Flash.copyData(file));
                else
                if (type == "break")
                    break;
                Console.ReadKey();
                Console.Clear();
            }

            //●	расчет необходимого количества носителей информации представленных типов для переноса информации.
            while (true)
            {
                Console.WriteLine("Выберите какой файл копировать за раз 565 Gb или 780 Mb в мегах (565000 или 780, ну или хоть че, адекватное)");
                double file = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите тип носителя (HDD, DVD, Flash) для расчета количества " +
                    "носителей информации представленных типов для переноса информации, (break для продолжения)");
                string type = Console.ReadLine();
                if (type == "HDD")
                    Console.WriteLine("необходимо {0} носителей", (int)(file / hdd.getCapacity()) + 1);
                else
                if (type == "DVD")
                    Console.WriteLine("необходимо {0} носителей", (int)(DVD.getCapacity()) + 1);
                else
                if (type == "Flash")
                    Console.WriteLine("необходимо {0} носителей", (int)(Flash.getCapacity()) + 1);
                else
                if (type == "break")
                    break;
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("хочешь, не хочешь но на полную инфу");
            Console.ReadKey();
            hdd.getInfo();
            Console.WriteLine();
            DVD.getInfo();
            Console.WriteLine();
            Flash.getInfo();
            Console.WriteLine();
        }
    }
}
