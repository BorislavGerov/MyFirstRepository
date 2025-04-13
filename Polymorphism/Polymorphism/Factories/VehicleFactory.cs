using Polymorphism.Factories.Interfaces;
using Polymorphism.Models;
using Polymorphism.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Factories
{
    public class VehicleFactory : IFactory
    {
        public IVehicle Create(string[] data)
        {
            string vehicleType = data[0];
            double fuelQuantity = double.Parse(data[1]);
            double fuelConsumption = double.Parse(data[2]);
            double conditionerConsumption = double.Parse(data[3]);

            switch (vehicleType)
            {
                case "Car":
                    IVehicle car = new Car(fuelQuantity, fuelConsumption, conditionerConsumption);
                    return car;
                    
                case "Truck":
                    IVehicle truck = new Truck(fuelQuantity, fuelConsumption, conditionerConsumption);
                    return truck;

                default:
                    throw new ArgumentException("Invalid type.");
            }
        }
    }
}
