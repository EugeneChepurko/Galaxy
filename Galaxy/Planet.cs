using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy
{
    class Planet
    {
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
    }
    
}
