
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propgramaproekt
{
    class City : pynkti
    {
        public City(string name, int population) : base(name, population)
        {
        }

        public void citygorod()
        {
            Console.WriteLine("Этот населенный пункт - город");
        }
    }
}
