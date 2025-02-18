using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS
{
    public class Lamp : Devices
    {
        public Lamp(string name) : base(name) { }
        
        public override void Function(double SensorValue)
        {
            Description = SensorValue < 50;
        }

        public void Toggle()
        {
            Description = !Description;
        }
    }
}
