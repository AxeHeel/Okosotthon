using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS
{
    public class Shutter : Devices
    {
        public double Position { get; set; }

        public Shutter(string name) : base(name) { }

        public override void Function(double sensorValue)
        {
            Position = sensorValue > 80 ? 0 : 100;
        }
    }
}
