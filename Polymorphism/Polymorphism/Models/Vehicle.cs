using Polymorphism.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Vehicle : IVehicle
    {
        private double airConditioneConsumption; 

        public Vehicle(double fuelQuantity, double fuelConsumption, double airConditioneConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            this.airConditioneConsumption = airConditioneConsumption;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public string Drive(double distance)
        {
            double consumption = FuelConsumption + airConditioneConsumption;
            if(FuelQuantity < distance * consumption)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling.");
            }

            FuelQuantity -= distance * consumption;
            return $"{this.GetType().Name} travelled {distance} km.";
        }

        public virtual void Refuel(double litters)
        {
            FuelQuantity += litters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
