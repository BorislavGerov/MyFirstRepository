using Polymorphism.Core.Interfaces;
using Polymorphism.Factories;
using Polymorphism.Factories.Interfaces;
using Polymorphism.IO;
using Polymorphism.IO.Interfaces;
using Polymorphism.Models;
using Polymorphism.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Core
{
    public class Engine : IEngine
    {
        private IFactory factory = new VehicleFactory();
        private List<IVehicle> vehicles = new List<IVehicle>();
        private IReader reader;
        private IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }
        public void Run()
        {
            int count = int.Parse(reader.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] vahicleInput = reader.ReadLine().Split(" ").ToArray();
                IVehicle vehicle = factory.Create(vahicleInput);
                vehicles.Add(vehicle);
            }
            
            int inputCount = int.Parse(reader.ReadLine());
            for (int i = 0; i < inputCount; i++)
            {
                string[] arrguments = reader.ReadLine().Split(" ").ToArray();
                string command = arrguments[0];
                string vehicleName = arrguments[1];
                IVehicle vehicle = vehicles.FirstOrDefault(v => v.GetType().Name == vehicleName);
                switch (command)
                {
                    case "Drive":
                        double kilometers = double.Parse(arrguments[2]);
                        Console.WriteLine(vehicle.Drive(kilometers));
                        break;

                    case "Refuel":
                        double litters = double.Parse(arrguments[2]);
                        vehicle.Refuel(litters);
                        break;
                }
            }

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }
    }
}
