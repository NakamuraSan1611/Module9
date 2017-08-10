using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    public class HDD : Storage
    {
        public string name;
        public string model;
        public double writeSpeed;
        public double readSpeed;
        public double capacity;
        public double available;
        public string type;
        public double parts;
        public double sections;
        public HDD(string name, string model, double capacity, string type)
        {
            this.name = name;
            this.model = model;
            this.type = type;
            this.capacity = this.available = capacity;
            Random rand = new Random();
            this.parts = rand.Next(50, 100);
            this.sections = rand.Next(100, 200);
            if (type == "3.0")
            {
                this.writeSpeed = 300;
                this.readSpeed = 500;
            }
            else
                if (type == "2.0")
            {
                this.writeSpeed = 60;
                this.readSpeed = 40;
            }
        }
        public override double getCapacity() { return capacity; }
        public override double copyData(double file)
        {
            if ((available - file) >= 0)
            {
                available -= file;
                Console.WriteLine("Файл записан!");
                return (file / writeSpeed);
            }
            else
            {
                Console.WriteLine("файл слишком велик");
                return 0;
            }
        }
        public override double getEmptySpace() { return available; }
        public override void getInfo()
        {
            Console.WriteLine("Name: {0}" +
                    "\nModel: {1}\nWriteSpeed: {2}\nReadSpeed: {3}\nCapacity: " +
                    "{4}\nType: {5}\nAvailable space: {6}\nSections: {7}\n Parts: {8}",
                    name, model, writeSpeed, readSpeed, capacity, type, available, sections, parts);
        }

    }
}
