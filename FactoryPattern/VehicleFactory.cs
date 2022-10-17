using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numWheels)
        {
           switch(numWheels)
            {
                case 1:
                    return new Monowheel();
                   
                case 2:
                    return new Motorcycle();
                    
                case 3:
                    return new Threewheeler();
                    
                case 4:
                    return new Car();
                    
                default:
                    return new Car();
                    
            }
        }
    }
}
