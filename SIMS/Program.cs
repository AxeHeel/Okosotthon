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
                Console.WriteLine("          ______________________________________      ");
                Console.WriteLine("         /\\                                     \\     ");
                Console.WriteLine("        /  \\                                     \\    ");
                Console.WriteLine("       /----\\-------------------------------------\\   ");
                Console.WriteLine("      /      \\                                     \\  ");
                Console.WriteLine("     /========\\=====================================\\ ");
                Console.WriteLine("    /          \\                                     \\");
                Console.WriteLine("    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                Console.WriteLine("    |  ______  |                                    |");
                Console.WriteLine("    |  |    |  | 1. Lamp turn on/off                |");
                Console.WriteLine("    |  |----|  | 2. Thermostat manual turn on/off   |");
                Console.WriteLine("    |  |    |  | 3. Update Sensor values   ______   |");
                Console.WriteLine("    |  ¯¯¯¯¯¯  | 4. Update the devices     |    |   |");
                Console.WriteLine("    |          | 5. Current state          |   _|   |");
                Console.WriteLine("    |          | 6. EXIT                   |    |   |");
                Console.Write("    |          | CHOOSE:                   |    |   |");
                Console.WriteLine();
                Console.WriteLine("    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");

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
                        try
                        {
                            Console.Write("What is the current light intensity (0 - 100) : ");
                            if (double.TryParse(Console.ReadLine(), out double newLight))
                            {
                                if (newLight < 0 || newLight > 100)
                                {
                                    throw new ArgumentOutOfRangeException(nameof(newLight), "The value was either way too low or way too high.");
                                }
                                lightSensor.Measure(newLight);
                            }
                            else
                            {
                                throw new FormatException("ts pmo icl sybau.");
                            }
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine($"ERROR: {ex.Message}");
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine($"ERROR: {ex.Message}");
                        }
                        try
                        {
                            Console.Write("Set a temperature for your function (°C) : ");
                            if (double.TryParse(Console.ReadLine(), out double newTemp))
                            {
                                if (newTemp < 10 || newTemp > 40)
                                {
                                    throw new ArgumentOutOfRangeException(nameof(newTemp), "The value was either way too low or way too high.");
                                }
                                tempSensor.Measure(newTemp);
                            }
                            else
                            {
                                throw new FormatException("Job had one bro.");
                            }
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine($"ERROR: {ex.Message}");
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine($"ERROR: {ex.Message}");
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
