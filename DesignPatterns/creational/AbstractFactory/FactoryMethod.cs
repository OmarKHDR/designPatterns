namespace Vehicles
{
	// product interface and concrete product
	abstract class Vehicle
	{
		public abstract void PrintVehicle();
	}

	class Car: Vehicle
	{
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
}

namespace Factories
{
	// creator interface and concrete creators
	interface VehicleFactory {
		Vehicles.Vehicle CreateVehicle();
	}

	class CarFactory: VehicleFactory {
		public Vehicles.Vehicle CreateVehicle() {
			return new Vehicles.Car();
		}
	}

	class BikeFactory: VehicleFactory {
		public Vehicles.Vehicle CreateVehicle() {
			return new Vehicles.Bike();
		}
	}

	class Creator {
		private readonly VehicleFactory factory;
		public Creator(VehicleFactory NewFactory) {
			this.factory = NewFactory;
		}

		public Vehicles.Vehicle GetVehicle() {
			return this.factory.CreateVehicle();
		}
	}
}

class Factorymethod
{
	static void Main(string[] args)
	{
		try
		{
			var carFactory = new Factories.Creator(new Factories.CarFactory());
			var bikeFactory = new Factories.Creator(new Factories.BikeFactory());
			carFactory.GetVehicle().PrintVehicle();
			bikeFactory.GetVehicle().PrintVehicle();
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error: {ex.Message}");
		}
	}
}