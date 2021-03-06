﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    public class DVD : Storage
    {
        public string name;
        public string model;
        public double writeSpeed = 1.32;
        public double readSpeed = 1.52;
        public double capacity;
        public double available;
        public string type;
        public DVD(string name, string model, string type)
        {
            this.name = name;
            this.model = model;
            this.type = type;
            if (type == "one side")
                this.capacity = this.available = 4700;
            else
                if (type == "double side")
                this.capacity = this.available = 9000;
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
                    "{4}\nType: {5}\nAvailable space: {6}", name, model, writeSpeed, readSpeed, capacity, type, available);
        }
    }
}
