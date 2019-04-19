using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy
{
    class System
    {
        public string Name { get; set; }
        public double Age { get; set; }
        public double Weight { get; set; }
        public uint Radius { get; set; }
        public int Temperature { get; set; }
        public List<Star> Stars { get; set; }
        public System()
        {
            Stars = new List<Star>();
            CreateSystem();
        }
        
        public void CreateSystem()
        {
            Random random = new Random();
            Name = "G3k0S's system S1";
            Age = random.Next(1, int.MaxValue);
            Radius = (uint)random.Next(900, 500000);
            Temperature = random.Next(-273, 1000000);
            Weight = random.NextDouble() * (int.MaxValue - 1);
        }

        public void AddStar(Star star)
        {
            Stars.Add(star);
        }

        public void ShowSystem()
        {
            Console.WriteLine($"Name - {Name}\nStar Count - {Stars.Count}\nAge - {Age} years\nRadius - {Radius} km\nTemperature - {Temperature}C\nWeight - {Weight} kg");
        }

        public void ShowStars()
        {
            int PlanetCount = 0;
            foreach (Star star in Stars)
            {
                PlanetCount += star.Planets.Count();

                Console.WriteLine($"System - {Name}\nStar - {star.Name}\nPlanet count in star - {PlanetCount}\nAge - {star.Age} years\nRadius - {star.Radius} km\nTemperature - {star.Temperature}C\nWeight - {star.Weight} kg");
                Console.WriteLine("-------------------------------------");
            }
        }
    }
}
