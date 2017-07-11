using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    public class HDD : Storage
    {
        public string name { get; set; }
        public string model { get; set; }
        public double capacity { get; set; }
        public double writeSpeed = 480;
        public double readSpeed = 400;
        public int diskPart = 200;
        public int diskPartVol = 8;
        public override double getCapacity() { return capacity; }
        public override double copyData() { return (capacity / writeSpeed + capacity / readSpeed); }
        public override double getEmptySpace() { return (capacity - file * (capacity / file)); }
        public override void getInfo() { }
    }
}
