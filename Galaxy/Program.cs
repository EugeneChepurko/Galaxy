using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galaxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            System f = new System();
            f.Name = "Solar system";
            Star s = new Star
            {
                Name = "Althair",
                Age = random.Next(10000, 1000000000),
                Radius = 10.43,
                Temperature = 25000,
                Weight = 466000
            };

            //Console.WriteLine($"Name - {s.Name}\nAge - {s.Age}\nRadius - {s.Radius}");

            StarPopulate g1 = new StarPopulate();

            for (int i = 0; i < 1000; i++)
            {
                g1.CreatePlanet();
                //Thread.Sleep(random.Next(10, 50));
            }

            // g1.ShowStarListPlanet();
            Console.WriteLine("----------------------------------------");
            g1.ShowPlanetWithLowTemp();
        }

        class StarPopulate
        {
            int index = 0;
            Star myStar = new Star();
            System system = new System();
            public void CreatePlanet()
            {
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
                        Thread.Sleep(random.Next(10, 100));
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

            public void ShowStarListPlanet()
            {
                foreach (var planet in myStar.Planets)
                {
                    Console.WriteLine(value: $"Name - {planet.Name}\nAge - {planet.Age} years\nRadius - {planet.Radius} km\nTemperature - {planet.Temperature}C\nWeight - {planet.Weight} kg");
                    Console.WriteLine("-------------------------------------");
                }
                Console.WriteLine($"Planet count - {myStar.Planets.Count}");
                Console.WriteLine($"This 56ft planet his temp -> {myStar.Planets[0].Temperature}");
            }

            public void ShowPlanetWithLowTemp()
            {
                for (int i = 0; i < myStar.Planets.Count; i++)
                {
                    if(myStar.Planets[i].Temperature < 50)
                    {
                        Console.WriteLine($"Planet found! Index {i}\nTemperature = {myStar.Planets[i].Temperature}");
                    }                   
                    //int index = myStar.Planets.FindIndex(t => t.Temperature < 50000);
                }            
            }
        }
    }
}
