using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galaxy
{
    class Star
    {
        Random random = new Random();
        public string Name { get; set; }
        public double Temperature { get; set; }
        public double Age { get; set; }
        public double Radius { get; set; }
        public double Weight { get; set; }
        public List<Planet> Planets { get; set; }

        public Star()
        {
            Planets = new List<Planet>();
            Create();
        }

        public Star(string name, double temp, double age, double radius, double weight){ }
        public void Create()
        {        
            Name = "G3k0S's star G1";
            Age = random.Next(1, int.MaxValue);
            Radius = random.Next(900, 500000);
            Temperature = random.Next(-273, 1000000);
            Weight = random.NextDouble() * (int.MaxValue - 1);
            Thread.Sleep(random.Next(10, 20));
        }

        public void AddPlanet(Planet planet)
        {
            int index = 0;
            if (index != -1 && index >= 1)
            {
                if (planet.Temperature == Planets[index - 1].Temperature)
                {
                    planet.Temperature = random.Next(-273, 1000000);
                    Thread.Sleep(random.Next(10, 60));
                }
            }
            // adding planet to star
            Planets.Add(planet);
            index++;
            Thread.Sleep(random.Next(10, 40));
        }

        public void Show()
        {
            Console.WriteLine($"Name - {Name}\nPlanet Count - {Planets.Count}\nAge - {Age} years\nRadius - {Radius} km\nTemperature - {Temperature}C\nWeight - {Weight} kg");
        }

        public void ShowListPlanet()
        {
            foreach (Planet planet in Planets)
            {
                Console.WriteLine($"Name - {planet.Name}\nAge - {planet.Age} years\nRadius - {planet.Radius} km\nTemperature - {planet.Temperature}C\nWeight - {planet.Weight} kg");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine($"Planet count - {Planets.Count}");
            Console.WriteLine($"This 56ft planet his temp -> {Planets[0].Temperature}");
        }

        public void ShowPlanetWithLowTemp()
        {
            for (int i = 0; i < Planets.Count; i++)
            {
                if (Planets[i].Temperature < 80)
                {
                    Console.WriteLine($"Planet found!\nIndex {i}\nTemperature = {Planets[i].Temperature}");
                }
            }
        }      
    }
}
