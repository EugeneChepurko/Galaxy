using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galaxy
{
    class Planet
    {
        Star myStar = new Star();
        public string Name { get; set; }
        public double Age { get; set; }
        public double Weight { get; set; }
        public uint Radius { get; set; }
        public int Temperature { get; set; }

        public Planet()
        {
            myStar.Create();
        }
        public Planet(string name, double age, double weight, uint radius, int temperature)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Radius = radius;
            Temperature = temperature;
        }
        //Create planet
        public void Create()
        {
            int index = 0;
            Random random = new Random();
            Planet planet = new Planet();

            planet.Name = "Unnamed planet";
            planet.Age = random.Next(1, int.MaxValue);
            planet.Radius = (uint)random.Next(900, 500000);
            planet.Temperature = random.Next(-273, 1000000);
            planet.Weight = random.NextDouble() * (int.MaxValue - 1);

            if (index != -1 && index >= 1)
            {
                if (planet.Temperature == myStar.Planets[index - 1].Temperature)
                {
                    planet.Temperature = random.Next(-273, 1000000);
                    Thread.Sleep(random.Next(10, 60));
                }
            }
            // adding planet to star
            myStar.AddPlanet(planet);
            index++;
            Thread.Sleep(random.Next(10, 40));
        }

        private void ShowPlanet(Planet planet)
        {
            Console.WriteLine($"Name - {planet.Name}\nAge - {planet.Age} years\nRadius - {planet.Radius} km\nTemperature - {planet.Temperature}C\nWeight - {planet.Weight} kg");
        }

        public void ShowStarListPlanet()
        {
            foreach (Planet planet in myStar.Planets)
            {
                Console.WriteLine(value: $"Star - {myStar.Name}\nName - {planet.Name}\nAge - {planet.Age} years\nRadius - {planet.Radius} km\nTemperature - {planet.Temperature}C\nWeight - {planet.Weight} kg");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine($"Planet count - {myStar.Planets.Count}");
            Console.WriteLine($"This 56ft planet his temp -> {myStar.Planets[0].Temperature}");
        }

        public void ShowPlanetWithLowTemp()
        {
            for (int i = 0; i < myStar.Planets.Count; i++)
            {
                if (myStar.Planets[i].Temperature < 500000)
                {
                    Console.WriteLine($"Planet found!\nIndex {i}\nTemperature = {myStar.Planets[i].Temperature}");
                }
            }
        }
    }
}
