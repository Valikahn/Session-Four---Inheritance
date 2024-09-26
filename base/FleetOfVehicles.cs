using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_Four___Inheritance.@base;

namespace Session_Four___Inheritance.@base
{
    public class FleetOfVehicles
    {
        private List<Vehicle> fleet;

        public FleetOfVehicles()
        {
            fleet = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            fleet.Add(vehicle);
            Console.WriteLine($"{vehicle.Make} {vehicle.Model} added to the fleet.");
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            fleet.Remove(vehicle);
            Console.WriteLine($"{vehicle.Make} {vehicle.Model} removed from the fleet.");
        }

        public void ListFleet()
        {
            Console.WriteLine("Current fleet:");
            foreach (var vehicle in fleet)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model} - Odometer: {vehicle.Odometer} km, Fuel: {vehicle.FuelLevel} liters");
            }
        }

        public void SimulateDrive(string make, string model, double hours)
        {
            var vehicle = fleet.Find(v => v.Make == make && v.Model == model);
            if (vehicle != null)
            {
                Console.WriteLine($"Simulating drive for {vehicle.Make} {vehicle.Model} for {hours} hours.");
                vehicle.Drive(hours);
            }
            else
            {
                Console.WriteLine($"Vehicle {make} {model} not found in the fleet.");
            }
        }
    }
}
