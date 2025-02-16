/*
* Abstract classes cannot be instantiated directly but the class drived from it
* is the one that is instantiated
* - used to define a common template between different classes
* - virtual method is implemented in base and may be overriden
* - abstract method has no implementation in base and must be overriden
* - both used to help creating template method for an interface like object to
*/
using System;

public abstract class animal
{
	public abstract string type {get;}
	public virtual void move()
	{
		Console.WriteLine("animal is moving");
	}
}

class cat: animal
{
	public override string type => "cat";
	public override void move()
	{
		Console.WriteLine($"{this.type} is moving");
	} 
}
class Proj
{
	static void Main()
	{
		cat c= new cat();
		c.move();
	}
}