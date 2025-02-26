using System;

try
{
	Signleton c = Signleton.GetInstance();
	c.GetId();
	Signleton b = Signleton.GetInstance();
	b.GetId();
}
catch(Exception err)
{
	Console.WriteLine($"{err}");
}


class Signleton
{
	private static Signleton instance = null;
	private string _id = "";
	private Signleton()
	{
		this._id = Guid.NewGuid().ToString();
		Console.WriteLine("Instance is Created");
	}

	public static Signleton GetInstance()
	{
		if (instance == null)
		{
			instance = new Signleton();
		}
		return instance;
	}

	public void GetId()
	{
		if (this._id != "" )
		{
			Console.WriteLine(this._id);
		}
		else
		{
			Console.WriteLine("no instance created");
		}
	}
}

