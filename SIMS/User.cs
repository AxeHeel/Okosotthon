using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS
{
    public class User
    {
        public List<Devices> devices = new List<Devices>();
        public List<Sensor> sensors = new List<Sensor>();

        public void UpdateDevices()
        {
            double lightValue = 0;
            double tempValue = 0;
            foreach (var sensor in sensors)
            {
                if (sensor is lightSensor)
                {
                    lightValue = sensor.Value;
                }
                if (sensor is tempSensor)
                {
                    tempValue = sensor.Value;
                }
            }
            foreach (var device in devices)
            {
                if (device is Lamp || device is Shutter)
                {
                    device.Function(lightValue);
                }
                else if (device is Thermostat)
                {
                    device.Function(tempValue);
                }
            }
        }
    }
}
