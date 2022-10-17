using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ConsoleLogging
    {
        public static void VehicleBuidDialogue()
        {
            Console.WriteLine("Gathering Federal and State permits...");
            Thread.Sleep(1350);
            Console.WriteLine("Constructing build kit...");
            Thread.Sleep(1350);
            
        }
    }
}
