using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propgramaproekt
{
    class pynkti
    {
        public string Name { get; set; }
        public int Population { get; set; }

        public pynkti(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public void inf()
        {
            Console.WriteLine($"Населенный пункт: {Name}");
            Console.WriteLine($"Население: {Population}");
        }
    }
}
