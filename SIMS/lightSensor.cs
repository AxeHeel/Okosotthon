using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS
{
    public class lightSensor : Sensor
    {
        public lightSensor(string name) : base(name) { }

        public override void Measure(double value)
        {
            Value = value;    
        }
    }
}
