using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double airConditioneConsumption) 
            : base(fuelQuantity, fuelConsumption, airConditioneConsumption)
        {

        }

        public override void Refuel(double litters)
        {
            base.Refuel(litters * 0.95); 
        }

    }
}
