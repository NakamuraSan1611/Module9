using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    public class DVD : Storage
    {
        public string name { get; set; }
        public string model { get; set; }
        public double writeSpeed = 1.32;
        public double readSpeed = 1.52;
        public double capacity { get; set; }
        public string type { get; set; }
        public DVD(string name, string model, string type)
        {
            this.name = name;
            this.model = model;
            this.type = type;
            if (type == "one side")
                this.capacity = 4.7;
            else
                if (type == "double side")
                this.capacity = 9;
        }
        public override double getCapacity() { return capacity; }
        public override double copyData() { return (capacity / writeSpeed + capacity / readSpeed); }
        public override double getEmptySpace() { return (capacity - file * (capacity / file)); }
        public override void getInfo() { Console.WriteLine("Name: {0}\nModel: {1}\nWriteSpeed: {2}\nReadSpeed: {3}\nCapacity: {4}\nType: {5}", name, model, writeSpeed, readSpeed, capacity, type); }
    }
}
