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
        Random random = new Random();
        ///Star myStar = new Star();  
        ///System system = new System();
        public string Name { get; set; }
        public double Age { get; set; }
        public double Weight { get; set; }
        public uint Radius { get; set; }
        public int Temperature { get; set; }

        public Planet()
        {
            ///system.AddStar(myStar);
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
        public Planet Create()
        {
            ///int index = 0;
            Planet planet = new Planet();

            planet.Name = "Unnamed planet";
            planet.Age = random.Next(1, int.MaxValue);
            planet.Radius = (uint)random.Next(900, 500000);
            planet.Temperature = random.Next(-273, 1000000);
            planet.Weight = random.NextDouble() * (int.MaxValue - 1);

            return planet;
            ////if (index != -1 && index >= 1)
            ////{
            ////    if (planet.Temperature == myStar.Planets[index - 1].Temperature)
            ////    {
            ////        planet.Temperature = random.Next(-273, 1000000);
            ////        Thread.Sleep(random.Next(10, 60));
            ////    }
            ////}
            ////// adding planet to star
            ////myStar.AddPlanet(planet);
            //////system.AddStarToSystem(myStar);
            ////index++;
            ////Thread.Sleep(random.Next(10, 40));
        }

        public void ShowPlanet(Planet planet)
        {
            Console.WriteLine($"Name - {planet.Name}\nAge - {planet.Age} years\nRadius - {planet.Radius} km\nTemperature - {planet.Temperature}C\nWeight - {planet.Weight} kg");
        }
        public void ShowPlanet()
        {
            Console.WriteLine($"Name - {Name}\nAge - {Age} years\nRadius - {Radius} km\nTemperature - {Temperature}C\nWeight - {Weight} kg");
        }    
    }
}
