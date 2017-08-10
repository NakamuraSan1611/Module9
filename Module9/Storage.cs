using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    public abstract class Storage
    {
        protected int file1 = 780;
        private string name;
        private string model;
        public abstract double getCapacity();
        public abstract double copyData(double file);
        public abstract double getEmptySpace();
        public abstract void getInfo();
    }
}
