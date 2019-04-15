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
        }

        public void CreateStar()
        {
            Random random = new Random();
            Star star = new Star();
            star.Name = "G3k0S's star G1";
            star.Age = random.Next(1, int.MaxValue);
            star.Radius = (uint)random.Next(900, 500000);
            star.Temperature = random.Next(-273, 1000000);
            star.Weight = random.NextDouble() * (int.MaxValue - 1);
            AddStarToSystem(star);           
        }
        public void CreateSystem()
        {
            Random random = new Random();
            System system = new System();
            system.Name = "G3k0S's system S1";
            system.Age = random.Next(1, int.MaxValue);
            system.Radius = (uint)random.Next(900, 500000);
            system.Temperature = random.Next(-273, 1000000);
            system.Weight = random.NextDouble() * (int.MaxValue - 1);
        }
        public void AddStarToSystem(Star star)
        {
            Stars.Add(star);
        }
    }
}
