using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy
{
    class Star
    {
        public string Name { get; set; }
        public double Temperature { get; set; }
        public double Age { get; set; }
        public double Radius { get; set; }
        public double Weight { get; set; }
        public List<Planet> Planets { get; set; }

        public Star()
        {
            Planets = new List<Planet>();
        }
        public Star(string name, double temp, double age, double radius, double weight)
        {

        }
        public void Create()
        {
            Random random = new Random();

            Name = "G3k0S's star G1";
            Age = random.Next(1, int.MaxValue);
            Radius = (uint)random.Next(900, 500000);
            Temperature = random.Next(-273, 1000000);
            Weight = random.NextDouble() * (int.MaxValue - 1);

        }
        public void AddPlanet(Planet planet)
        {
            Planets.Add(planet);
        }
        public void ShowStarListPlanet()
        {
            foreach (var planet in Planets)
            {
                Console.WriteLine(value: $"Name - {planet.Name}\nAge - {planet.Age} years\nRadius - {planet.Radius} km\nTemperature - {planet.Temperature}C\nWeight - {planet.Weight} kg");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine($"Planet count - {Planets.Count}");
            Console.WriteLine($"This 56ft planet his temp -> {Planets[0].Temperature}");
        }
        public void Show()
        {
            Console.WriteLine(Name);
        }
    }
}
