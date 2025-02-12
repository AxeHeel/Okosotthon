using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS
{
    public class Sensor
    {
        public int Temperature {  get; set; }
        public string LightCond { get; set; }
        public Sensor(int temperature, string lightcond) 
        {
            this.Temperature = temperature;
            this.LightCond = lightcond;
        }




    }
}
