using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Four___Inheritance
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public double FuelEfficiency { get; set; } // in km per liter

        public Car(string make, string model, int year, double fuelLevel, int numberOfDoors, double fuelEfficiency)
            : base(make, model, year, fuelLevel)
        {
            NumberOfDoors = numberOfDoors;
            FuelEfficiency = fuelEfficiency;
        }

        protected override double FuelConsumptionRate()
        {
            return CurrentSpeed / FuelEfficiency;
        }
    }

}
