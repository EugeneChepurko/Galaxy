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
            System system = new System();
            Thread.Sleep(10);
            Star star = new Star();
            star.Planets.Count();
       

            // add star to system
            system.AddStar(star);

            // create a planet
            Planet planet = new Planet();
            for (int i = 0; i < 10; i++)
            {
                star.AddPlanet(planet.Create());
            }
            //show
            //star.ShowListPlanet();
            //star.ShowPlanetWithLowTemp();
            system.ShowStars();

            //------------------------------------------
            //Planet planet = new Planet();
            //Count of planet
            //for (int i = 0; i < 3; i++)
            //{
            //    planet.Create();
            //}

            ////planet.ShowPlanetWithLowTemp();
            //planet.ShowStarListPlanet();

            // ====================================== NEW
            //System system = new System();
            //Star star = new Star();
            //system.CreateSystem();
            //star.CreateStar();
            //system.ShowStars();
            //system.ShowSystem();


            //System s = new System();

            //s.ShowSystem();
        }  
    }
}