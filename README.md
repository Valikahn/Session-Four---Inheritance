# Session Four - Inheritance

## Classes - Inheritance Tutorial

### **Instructions**<br>
You are working on a project that involves creating a program to manage a fleet of vehicles. The vehicles can be of different types such as cars, trucks, and motorcycles, and each type of vehicle has its own set of properties and behaviours.

Your task is to create a class hierarchy for the vehicles, where each type of vehicle is represented by a class that inherits from a base Vehicle class. The base Vehicle class should contain common properties and behaviours that are shared by all types of vehicles, such as the make, model, and year of the vehicle, as well as methods to accelerate, brake, and turn.

Each subclass of Vehicle should add its own specific properties and behaviours that are unique to that type of vehicle. For example, the Car class might have properties like the number of doors and the fuel efficiency, while the Truck class might have properties like the cargo capacity and the towing capacity.

Once you have created the class hierarchy, you should create a program that allows the user to create and manage a fleet of vehicles. The user should be able to add, remove, and modify vehicles in the fleet, as well as view information about each vehicle, such as its current speed, fuel level, and odometer reading.

| Truck           | Motorcycle | Car             | Vehicle       | Fleet |
|-----------------|------------|-----------------|---------------|-------|
| Cargo Capacity  | Sidecar    | Number of Doors | Make          |       |
| Towing Capacity |            | Fuel Efficiency | Model         |       |
|                 |            |                 | Year          |       |
|                 |            |                 | Odometer      |       |
|                 |            |                 | Fuel Level    |       |
|                 |            |                 | Current Speed |       |
|                 |            |                 | Accelerate    |       |
|                 |            |                 | Brake         |       |
|                 |            |                 | Turn          |       |
|                 |            |                 | Drive         |       |

In addition, you should implement a feature that allows the user to simulate driving each vehicle in the fleet. The user should be able to specify how long they want to drive the vehicle, and the program should update the vehicle's properties accordingly, such as decreasing the fuel level and increasing the odometer reading.
