using System;
using System.Collections.Generic;

namespace _09TrafficLights
{
    using Enums;
    public class Startup
    {
        public static void Main()
        {
            List<TrafficLight> lights = new List<TrafficLight>();
            
            string[] colors = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < colors.Length; i++)
            {
                lights.Add((TrafficLight)Enum.Parse(typeof(TrafficLight), colors[i], true));
            }

            int count = int.Parse(Console.ReadLine());

            while (count > 0)
            {
                for (int i = 0; i < lights.Count; i++)
                {
                    if (lights[i] == TrafficLight.Red)
                    {
                        lights[i] = TrafficLight.Green;
                    }
                    else if (lights[i] == TrafficLight.Yellow)
                    {
                        lights[i] = TrafficLight.Red;
                    }
                    else
                    {
                        lights[i] = TrafficLight.Yellow;
                    }
                }

                Console.WriteLine(string.Join(" ", lights));
                count--;
            }
            
        }
    }
}
