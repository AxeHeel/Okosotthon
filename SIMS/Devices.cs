using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS
{
    public abstract class Devices
    {
        public string Name { get; set; }
        public bool Description { get; set; }

        public Devices(string name) 
        {
            Name = name;
        }
        public abstract void Function(double sensorValue);

    }
}
