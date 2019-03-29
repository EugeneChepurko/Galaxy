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
        public List<Star> Stars { get; set; }
        public System()
        {
            Stars = new List<Star>();
        }
    }
}
