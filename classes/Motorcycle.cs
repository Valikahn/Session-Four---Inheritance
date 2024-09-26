using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Four___Inheritance.classes
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string make, string model, int year, double fuelLevel, bool hasSidecar)
            : base(make, model, year, fuelLevel)
        {
            HasSidecar = hasSidecar;
        }

        protected override double FuelConsumptionRate()
        {
            return CurrentSpeed / 20.0; // Motorcycles are typically fuel efficient
        }
    }

}
