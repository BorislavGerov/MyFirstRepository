using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double airConditioneConsumption) 
            : base(fuelQuantity, fuelConsumption, airConditioneConsumption)
        {

        }

    }
}
