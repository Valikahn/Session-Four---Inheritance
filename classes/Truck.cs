using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Four___Inheritance.classes
{
    public class Truck : Vehicle
    {
        public double CargoCapacity { get; set; } // in tons
        public double TowingCapacity { get; set; } // in tons

        public Truck(string make, string model, int year, double fuelLevel, double cargoCapacity, double towingCapacity)
            : base(make, model, year, fuelLevel)
        {
            CargoCapacity = cargoCapacity;
            TowingCapacity = towingCapacity;
        }

        protected override double FuelConsumptionRate()
        {
            return CurrentSpeed / 5.0; // Arbitrary fuel consumption rate for trucks
        }
    }

}
