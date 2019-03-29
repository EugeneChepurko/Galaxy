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
        public void ShowStarListPlanet()
        {
            Star myStar = new Star();
            foreach (var planet in myStar.Planets)
            {
                Console.WriteLine(value: $"Name - {planet.Name}\nAge - {planet.Age} years\nRadius - {planet.Radius} km\nTemperature - {planet.Temperature}C\nWeight - {planet.Weight} kg");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine($"Planet count - {myStar.Planets.Count}");
            Console.WriteLine($"This 56ft planet his temp -> {myStar.Planets[0].Temperature}");
        }
    }
}
