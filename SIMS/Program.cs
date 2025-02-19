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
                if (Lamp.Description)
                {
                    Console.WriteLine("          ______________________________________      ");
                    Console.WriteLine("         /\\                                     \\     ");
                    Console.WriteLine("        /  \\                                     \\    ");
                    Console.WriteLine("       /----\\-------------------------------------\\   ");
                    Console.WriteLine("      /      \\                                     \\  ");
                    Console.WriteLine("     /========\\=====================================\\ ");
                    Console.WriteLine("    /          \\                                     \\");
                    Console.WriteLine("    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                    Console.WriteLine("    |  ______  |                                    |");
                    Console.WriteLine("    |  |████|  | 1. Lamp turn on/off                |");
                    Console.WriteLine("    |  |----|  | 2. Thermostat manual turn on/off   |");
                    Console.WriteLine("    |  |████|  | 3. Update Sensor values   ______   |");
                    Console.WriteLine("    |  ¯¯¯¯¯¯  | 4. Update the devices     |    |   |");
                    Console.WriteLine("    |          | 5. Current state          |   _|   |");
                    Console.WriteLine("    |          | 6. EXIT                   |    |   |");
                    Console.Write("    |          | CHOOSE:                   |    |   |");
                    Console.WriteLine();
                    Console.WriteLine("    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                }
                else
                {
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
                }

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        if (!Lamp.Description)
                        {
                            Console.Clear();
                            Lamp.Toggle();
                            Console.WriteLine("          ______________________________________      ");
                            Console.WriteLine("         /\\                                     \\     ");
                            Console.WriteLine("        /  \\                                     \\    ");
                            Console.WriteLine("       /----\\-------------------------------------\\   ");
                            Console.WriteLine("      /      \\                                     \\  ");
                            Console.WriteLine("     /========\\=====================================\\ ");
                            Console.WriteLine("    /          \\                                     \\");
                            Console.WriteLine("    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                            Console.WriteLine("    |  ______  |                                    |");
                            Console.WriteLine("    |  |████|  |                                    |");
                            Console.WriteLine("    |  |----|  |                                    |");
                            Console.WriteLine("    |  |████|  |                           ______   |");
                            Console.WriteLine("    |  ¯¯¯¯¯¯  |                           |    |   |");
                            Console.WriteLine("    |          |                           |   _|   |");
                            Console.WriteLine("    |          |                           |    |   |");
                            Console.Write("    |          |                           |    |   |");
                            Console.WriteLine();
                            Console.WriteLine("    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                            LampDes(Lamp);
                        }
                        else
                        {
                            Console.Clear();
                            Lamp.Toggle();
                            Console.WriteLine("          ______________________________________      ");
                            Console.WriteLine("         /\\                                     \\     ");
                            Console.WriteLine("        /  \\                                     \\    ");
                            Console.WriteLine("       /----\\-------------------------------------\\   ");
                            Console.WriteLine("      /      \\                                     \\  ");
                            Console.WriteLine("     /========\\=====================================\\ ");
                            Console.WriteLine("    /          \\                                     \\");
                            Console.WriteLine("    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                            Console.WriteLine("    |  ______  |                                    |");
                            Console.WriteLine("    |  |    |  |                                    |");
                            Console.WriteLine("    |  |----|  |                                    |");
                            Console.WriteLine("    |  |    |  |                           ______   |");
                            Console.WriteLine("    |  ¯¯¯¯¯¯  |                           |    |   |");
                            Console.WriteLine("    |          |                           |   _|   |");
                            Console.WriteLine("    |          |                           |    |   |");
                            Console.Write("    |          |                           |    |   |");
                            Console.WriteLine();
                            Console.WriteLine("    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                            LampDes(Lamp);
                        }
                        break;

                    case "2":
                        Console.Clear();
                        Thermostat.ToggleHeating();
                        Console.WriteLine("          ______________________________________      ");
                        Console.WriteLine("         /\\                                     \\     ");
                        Console.WriteLine("        /  \\                                     \\    ");
                        Console.WriteLine("       /----\\-------------------------------------\\   ");
                        Console.WriteLine("      /      \\                                     \\  ");
                        Console.WriteLine("     /========\\=====================================\\ ");
                        Console.WriteLine("    /          \\                                     \\");
                        Console.WriteLine("    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                        Console.WriteLine("    |  ______  |                                    |");
                        Console.WriteLine("    |  |    |  |                                    |");
                        Console.WriteLine("    |  |----|  |                                    |");
                        Console.WriteLine("    |  |    |  |                           ______   |");
                        Console.WriteLine("    |  ¯¯¯¯¯¯  |                           |    |   |");
                        Console.WriteLine("    |          |                           |   _|   |");
                        Console.WriteLine("    |          |                           |    |   |");
                        Console.Write("    |          |                           |    |   |");
                        Console.WriteLine();
                        Console.WriteLine("    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                        ThermDes(Thermostat);
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
                        Console.WriteLine("          ______________________________________      ");
                        Console.WriteLine("         /\\                                     \\     ");
                        Console.WriteLine("        /  \\                                     \\    ");
                        Console.WriteLine("       /----\\-------------------------------------\\   ");
                        Console.WriteLine("      /      \\                                     \\  ");
                        Console.WriteLine("     /========\\=====================================\\ ");
                        Console.WriteLine("    /          \\                                     \\");
                        Console.WriteLine("    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                        Console.WriteLine("    |  ______  |                                    |");
                        Console.WriteLine("    |  |    |  |                                    |");
                        Console.WriteLine("    |  |----|  |                                    |");
                        Console.WriteLine("    |  |    |  |                           ______   |");
                        Console.WriteLine("    |  ¯¯¯¯¯¯  |                           |    |   |");
                        Console.WriteLine("    |          |                           |   _|   |");
                        Console.WriteLine("    |          |                           |    |   |");
                        Console.Write("    |          |                           |    |   |");
                        Console.WriteLine();
                        Console.WriteLine("    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                        UserUpdate();
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("\t---------- Sensor Value ----------");
                        Console.WriteLine();
                        Console.WriteLine($"\t{lightSensor.Name}: {lightSensor.Value}");
                        Console.WriteLine($"\t{tempSensor.Name}: {tempSensor.Value}");
                        Console.WriteLine();
                        Console.WriteLine("==========================================================");
                        Console.WriteLine();
                        Console.WriteLine("\t---------- Device Status ----------");
                        Console.WriteLine();
                        Console.WriteLine($"\t{Lamp.Name}: {(Lamp.Description ? "ON" : "OFF")}");
                        Console.WriteLine($"\t{Thermostat.Name}: {(Thermostat.Heating ? "ON" : "OFF")} (Current temperature: {Thermostat.Temperature} °C)");
                        Console.WriteLine($"\t{Shutter.Name}: {Shutter.Position} (0 = closed, 100 = opened)");
                        break;

                    case "6":
                        exit = true;
                        continue;

                    default:
                        Console.WriteLine("That won't work here lil bro.");
                        break;
                }
                Console.SetCursorPosition(18, 16);
                Console.WriteLine("\nPRESS ENTER TO CONTINUE...");
                Console.ReadLine();
            }
        }
        public static void LampDes(Lamp lamp)
        {
            Console.SetCursorPosition(17, 9);
            string s = $"The {lamp.Name} is {(lamp.Description ? "ON." : "OFF")}.";
            foreach (char c in s)
            {
                System.Threading.Thread.Sleep(100);
                Console.Write(c);
            }
        }
        public static void ThermDes(Thermostat therm)
        {
            Console.SetCursorPosition(17, 9);
            string s = $"The {therm.Name} is {(therm.Heating ? "ON." : "OFF")}.";
            foreach (char c in s)
            {
                System.Threading.Thread.Sleep(100);
                Console.Write(c);
            }
        }
        public static void UserUpdate()
        {
            Console.SetCursorPosition(17, 9);
            string s = "The devices were updated by a user.";
            foreach (char c in s)
            {
                System.Threading.Thread.Sleep(100);
                Console.Write(c);
            }
        }
    }
}
