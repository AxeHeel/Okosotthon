using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace SIMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Lamp Lamp = new Lamp("Lamp");
            Thermostat Thermostat = new Thermostat("Thermostat");
            Shutter Shutter = new Shutter("Shutter");

            user.devices.Add(Lamp);
            user.devices.Add(Thermostat);
            user.devices.Add(Shutter);

            lightSensor lightSensor = new lightSensor("Light Sensor");
            tempSensor tempSensor = new tempSensor("Temperature Sensor");

            user.sensors.Add(lightSensor);
            user.sensors.Add(tempSensor);

            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("==== SMART CRIB ====");
                Console.WriteLine("1. Lamp turn on/off");
                Console.WriteLine("2. Thermostat manual turn on/off");
                Console.WriteLine("3. Update Sensor values");
                Console.WriteLine("4. Update the devices");
                Console.WriteLine("5. Current state");
                Console.WriteLine("6. EXIT");
                Console.Write("CHOOSE: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Lamp.Toggle();
                        Console.WriteLine($"The {Lamp.Name} is {(Lamp.Description ? "ON" : "OFF")}.");
                        break;

                    case "2":
                        Console.Clear();
                        Thermostat.ToggleHeating();
                        Console.WriteLine($"The {Thermostat.Name} is currently {(Thermostat.Heating ? "heating up" : "chillin out")} yo crib .");
                        break;

                    case "3":
                        Console.Clear();
                        Console.Write("How light do you want your room to be (0-100): ");
                        if (double.TryParse(Console.ReadLine(), out double newLight))
                        {
                            lightSensor.Measure(newLight);
                        }
                        else
                        {
                            Console.WriteLine("ts pmo icl sybau.");
                        }

                        Console.Write("Set a temperature for your function (°C): ");
                        if (double.TryParse(Console.ReadLine(), out double newTemp))
                        {
                            tempSensor.Measure(newTemp);
                        }
                        else
                        {
                            Console.WriteLine("Job had one bro.");
                        }
                        break;

                    case "4":
                        Console.Clear();
                        user.UpdateDevices();
                        Console.WriteLine("The devices were updated by the owner.");
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("---- Sensor Value ----");
                        Console.WriteLine($"{lightSensor.Name}: {lightSensor.Value}");
                        Console.WriteLine($"{tempSensor.Name}: {tempSensor.Value}");
                        Console.WriteLine();
                        Console.WriteLine("---- Device Status ----");
                        Console.WriteLine($"{Lamp.Name}: {(Lamp.Description ? "ON" : "OFF")}");
                        Console.WriteLine($"{Thermostat.Name} is {(Thermostat.Heating ? "heating up" : "chillin out")} (Current temperature: {Thermostat.Temperature} °C)");
                        Console.WriteLine($"{Shutter.Name}: {Shutter.Position} (0 = closed, 100 = opened)");
                        break;

                    case "6":
                        exit = true;
                        continue;

                    default:
                        Console.WriteLine("That won't work here lil bro.");
                        break;
                }

                Console.WriteLine("\nPRESS ENTER TO CONTINUE...");
                Console.ReadLine();
            }
        }
    }
}
