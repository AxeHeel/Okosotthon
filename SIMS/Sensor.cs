using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS
{
    public abstract class Sensor
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public Sensor(string name) 
        {
            Name = name;
        }

        public abstract void Measure(double value);
    }
}
