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
            Planet planet = new Planet();

            //Count of planet
            for (int i = 0; i < 3; i++)
            {
                planet.Create();
            }
            
            //planet.ShowPlanetWithLowTemp();
            planet.ShowStarListPlanet();
        }  
    }
}