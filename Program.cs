using Session_Four___Inheritance.@base;
using Session_Four___Inheritance.classes;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        FleetOfVehicles fleet = new FleetOfVehicles();

        Car car1 = new Car("Honda", "Civic", 2020, 40, 4, 18);
        Truck truck1 = new Truck("Ram", "2500", 2019, 100, 10, 15);
        Motorcycle bike1 = new Motorcycle("Yamaha", "MT-07", 2021, 15, false);

        fleet.AddVehicle(car1);
        fleet.AddVehicle(truck1);
        fleet.AddVehicle(bike1);

        Console.WriteLine("\n--- Initial Fleet ---");
        fleet.ListFleet();

        Console.WriteLine("\n--- Simulating Driving the Honda Civic for 3 hours ---");
        car1.Accelerate(80);
        fleet.SimulateDrive("Honda", "Civic", 3);

        Console.WriteLine("\n--- Simulating Driving the Ram 2500 for 5 hours ---");
        truck1.Accelerate(60);
        fleet.SimulateDrive("Ram", "2500", 5);

        Console.WriteLine("\n--- Simulating Driving the Yamaha MT-07 without Fuel ---");
        bike1.Accelerate(100);
        bike1.FuelLevel = 0;
        fleet.SimulateDrive("Yamaha", "MT-07", 1);

        Console.WriteLine("\n--- Simulating Acceleration and Braking on Honda Civic ---");
        car1.Accelerate(50);
        car1.Brake(30);

        Console.WriteLine("\n--- Updated Fleet After Driving ---");
        fleet.ListFleet();

        Console.WriteLine("\n--- Removing Yamaha MT-07 from Fleet ---");
        fleet.RemoveVehicle(bike1);

        Console.WriteLine("\n--- Fleet After Removing the Yamaha MT-07 ---");
        fleet.ListFleet();
    }
}
