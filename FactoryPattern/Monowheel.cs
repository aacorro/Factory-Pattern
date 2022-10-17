using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Monowheel : IVehicle
    {
        public Monowheel()
        {
        }

        public void Drive()
        {
            ConsoleLogging.VehicleBuidDialogue();
            Console.WriteLine("Building a new Monowheel!");
        }
    }
}
