using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS
{
    public class Thermostat : Devices
    {
        public double Temperature { get; set; }
        public bool Heating { get; set; }

        public Thermostat(string name) : base(name) { }

        public override void Function(double sensorValue)
        {
            Heating = sensorValue < 20;
            Temperature = sensorValue;
        }

        public void ToggleHeating()
        {
            Heating = !Heating;
        }
    }
}
