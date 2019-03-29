using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galaxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread thread = Thread.CurrentThread;
            //thread.Name = "Main thread";

            //Thread thread2 = new Thread(new ParameterizedThreadStart(Add));
            //thread2.Start(planet);

            Planet planet = new Planet();
            //Count of planet
            for (int i = 0; i < 100; i++)
            {
                planet.CreatePlanet();
            }

            // g1.ShowStarListPlanet();
            Console.WriteLine("----------------------------------------");
            planet.ShowPlanetWithLowTemp();
        }
        //public static void Add(object p)
        //{
        //    Planet planet = (Planet)p;
        //    for (int i = 0; i < 100; i++)
        //    {
        //        planet.CreatePlanet();
        //    }
        //}

        //class StarPopulate
        //{
        //    int index = 0;
        //    Star myStar = new Star();
        //    System system = new System();
        //    public void CreatePlanet()
        //    {
        //        Random random = new Random();
        //        Planet planet = new Planet();
        //        planet.Name = "Unnamed planet";
        //        planet.Age = random.Next(1, int.MaxValue);
        //        planet.Radius = random.NextDouble() * (int.MaxValue - 1);
        //        planet.Temperature = random.Next(-273, 1000000);
        //        planet.Weight = random.NextDouble() * (int.MaxValue - 1);

        //        if (index != -1 && index >= 1)
        //        {
        //            if (planet.Temperature == myStar.Planets[index - 1].Temperature)
        //            {
        //                planet.Temperature = random.Next(-273, 1000000);
        //                Thread.Sleep(random.Next(10, 60));
        //            }
        //        }
        //        // adding planet to star
        //        myStar.Planets.Add(planet);
        //        index++;
        //        Thread.Sleep(random.Next(10, 40));
        //    }

        //    private void ShowPlanet(Planet planet)
        //    {
        //        Console.WriteLine($"Name - {planet.Name}\nAge - {planet.Age} years\nRadius - {planet.Radius} km\nTemperature - {planet.Temperature}C\nWeight - {planet.Weight} kg");
        //    }

        //    public void ShowStarListPlanet()
        //    {
        //        foreach (var planet in myStar.Planets)
        //        {
        //            Console.WriteLine(value: $"Name - {planet.Name}\nAge - {planet.Age} years\nRadius - {planet.Radius} km\nTemperature - {planet.Temperature}C\nWeight - {planet.Weight} kg");
        //            Console.WriteLine("-------------------------------------");
        //        }
        //        Console.WriteLine($"Planet count - {myStar.Planets.Count}");
        //        Console.WriteLine($"This 56ft planet his temp -> {myStar.Planets[0].Temperature}");
        //    }

        //    public void ShowPlanetWithLowTemp()
        //    {
        //        for (int i = 0; i < myStar.Planets.Count; i++)
        //        {
        //            if(myStar.Planets[i].Temperature < 500000)
        //            {
        //                Console.WriteLine($"Planet found! Index {i}\nTemperature = {myStar.Planets[i].Temperature}");
        //            }                   
        //            //int index = myStar.Planets.FindIndex(t => t.Temperature < 50000);
        //        }            
        //    }
        //}
    }
}