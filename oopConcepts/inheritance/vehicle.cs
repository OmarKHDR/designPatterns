using System;

namespace BaseClasses
{
	class Vehicle
	{
		public string name = "";

		public Vehicle(string name)
		{
			this.name = name;
		}

		public void start()
		{
			Console.WriteLine($"starting the {this.GetType().Name} {this.name}");
		}

		public void stop()
		{
			Console.WriteLine($"stopping the {this.GetType().Name} {this.name}");
		}
	}
}

namespace ChildClasses
{
	class Car: BaseClasses.Vehicle
	{
		public Car(string name) : base(name) { }
	}

	class MotorCycle: BaseClasses.Vehicle
	{
		public MotorCycle(string name) : base(name) { }
	}
}