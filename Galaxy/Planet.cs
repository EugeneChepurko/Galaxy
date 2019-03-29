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
        public double Radius { get; set; }
        public int Temperature { get; set; }

        public Planet()
        {

        }
        public Planet(string name, double age, double weight, double radius, int temperature)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Radius = radius;
            Temperature = temperature;
        }
        public void CreatePlanet()
        {
            int index = 0;
            Random random = new Random();

            Planet planet = new Planet();
            planet.Name = "Unnamed planet";
            planet.Age = random.Next(1, int.MaxValue);
            planet.Radius = random.NextDouble() * (int.MaxValue - 1);
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
            myStar.Planets.Add(planet);
            index++;
            Thread.Sleep(random.Next(10, 40));
        }

        private void ShowPlanet(Planet planet)
        {
            Console.WriteLine($"Name - {planet.Name}\nAge - {planet.Age} years\nRadius - {planet.Radius} km\nTemperature - {planet.Temperature}C\nWeight - {planet.Weight} kg");
        }

        public void ShowPlanetWithLowTemp()
        {
            for (int i = 0; i < myStar.Planets.Count; i++)
            {
                if (myStar.Planets[i].Temperature < 50000)
                {
                    Console.WriteLine($"Planet found! Index {i}\nTemperature = {myStar.Planets[i].Temperature}");
                }
                //int index = myStar.Planets.FindIndex(t => t.Temperature < 50000);
            }
        }
    }
}
