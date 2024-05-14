using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propgramaproekt
{
    class Village : pynkti
    {
        public Village(string name, int population) : base(name, population)
        {
        }

        public void IsVillage()
        {
            Console.WriteLine("Этот населенный пункт - деревня");
        }
    }
}
