using System;

/*
	this code isnot optimal factory pattern as it uses one class to create the objects
	that makes adding new vehicle types will be problematic as it needs modification of
	VehicleFactory class
	noticing the code VehicleFactory is directly coupled to low level details
	to solve that we can make an interface all factories should follow then use an instance of that
	interface inside the VehicleFactory class

*/
enum VehicleTypes {
	Car,
	Bike,
}
abstract class Vehicle
{
	// product interface
	public abstract void PrintVehicle();
}

class Car: Vehicle
{
	//concrete product
	public override void PrintVehicle()
	{
		Console.WriteLine("This is a car");
	}
}

class Bike: Vehicle
{
	public override void PrintVehicle()
	{
		Console.WriteLine("This is a bike");
	}
}

class VehicleFactory
{
	private readonly Vehicle _MyVehivle;

	public VehicleFactory(VehicleTypes type)
	{
		this._MyVehivle = type switch 
		{
			VehicleTypes.Car => new Car(),
			VehicleTypes.Bike  => new Bike(),
			_ => throw new Exception($"{type} not a valid class")
		};
	}

	public Vehicle GetVehicle() {
		return this._MyVehivle;
	}
}

class Program
{
	static void Main(string[] args)
	{
		try
		{
			var carFactory = new VehicleFactory(VehicleTypes.Car);
			var bikeFactory = new VehicleFactory(VehicleTypes.Bike);
			carFactory.GetVehicle().PrintVehicle();
			bikeFactory.GetVehicle().PrintVehicle();
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error: {ex.Message}");
		}
	}
}