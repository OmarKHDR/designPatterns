
using System;
using bank;
/*
* encapsulation: is isolating the critical code parts and allowing access
* 				 onl from a pre-made safer functions 
* account has a property balance that shouldn't be edited without checking its value
* so we create a withdrawal and deposite methods to check the amount added or substracted
*
*/

class Encapsulation
{
	public static void Main()
	{
		bank.BankAccount user = new bank.BankAccount();
		user.deposite(200);
		Console.WriteLine($"new balance = {user.GetBalance()}");
		user.withdraw(100);
		Console.WriteLine($"new balance = {user.GetBalance()}");
		//withdraw more than balance
		try
		{
			Console.WriteLine("Try withdrawing more than balance...");
			user.withdraw(1000);
		}
		catch(Exception err)
		{
			Console.WriteLine($"Exception thrown: {err.Message}");
		}
		//withdraw negative amount
		try
		{
			Console.WriteLine("Try withdrawing negative amount...");
			user.withdraw(-100);
		}
		catch(Exception err)
		{
			Console.WriteLine($"Exception thrown: {err.Message}");
		}
		//deposite negative amount
		try
		{
			Console.WriteLine("Try depositing negative amount...");
			user.deposite(-100);
		}
		catch(Exception err)
		{
			Console.WriteLine($"Exception thrown: {err.Message}");
		}
	}
}
