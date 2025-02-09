using System;
using BaseClasses;
using ChildClasses;
/*
* Inheritance: lowering the chance of code duplication by making a base class that
*			   is common betwen other classes, making and {is-a} relation ship
* a car is a vehicle, a motorcycle is a vehicle so both can have the same parent class 
* a rectangle is a shape and square is a shape so both can have the same parent class
*/

class Inheritance
{
	static void Main()
	{
		BaseClasses.Vehicle v = new BaseClasses.Vehicle("spaceship");
		v.start();
		v.stop();

        ChildClasses.Car myCar = new ChildClasses.Car("Toyota");
        myCar.start();
        myCar.stop();

        ChildClasses.MotorCycle myBike = new ChildClasses.MotorCycle("Harley");
        myBike.start();
        myBike.stop();
	}
}