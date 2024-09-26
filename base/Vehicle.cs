using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Four___Inheritance.@base
{
    using System;

    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Odometer { get; set; }
        public double FuelLevel { get; set; }
        public double CurrentSpeed { get; private set; }

        public Vehicle(string make, string model, int year, double fuelLevel)
        {
            Make = make;
            Model = model;
            Year = year;
            Odometer = 0;
            FuelLevel = fuelLevel;
            CurrentSpeed = 0;
        }

        public virtual void Accelerate(double amount)
        {
            CurrentSpeed += amount;
            Console.WriteLine($"{Make} {Model} is now going at {CurrentSpeed} MPH.");
        }

        public virtual void Brake(double amount)
        {
            CurrentSpeed -= amount;
            if (CurrentSpeed < 0)
                CurrentSpeed = 0;

            Console.WriteLine($"{Make} {Model} is now going at {CurrentSpeed} MPH.");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"{Make} {Model} is turning {direction}.");
        }

        public void Drive(double hours)
        {
            if (FuelLevel <= 0)
            {
                Console.WriteLine($"{Make} {Model} has no fuel to drive.");
                return;
            }

            double distance = CurrentSpeed * hours;
            Odometer += distance;
            FuelLevel -= hours * FuelConsumptionRate();

            if (FuelLevel < 0) FuelLevel = 0;

            Console.WriteLine($"{Make} {Model} drove {distance} mile. Odometer: {Odometer} mile. Fuel level: {FuelLevel} liters.");
        }

        protected abstract double FuelConsumptionRate();
    }

}
