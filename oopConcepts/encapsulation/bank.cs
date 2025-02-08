using System;

namespace bank
{
	public class BankAccount
{
	private double balance;

	public BankAccount()
	{
		this.balance = 0;
	}

	public double GetBalance()
	{
		return this.balance;
	}

	public double deposite(double amount)
	{
		if (amount <= 0)
		{
			throw new Exception("amount deposit must be higher than zero");
		}
		else
		{
			Console.Write($"depositing {amount} ..... ");
			this.balance += amount;
			return this.balance;
		}
	}

	public double withdraw(double amount)
	{
		if (amount <=0 )
		{
			throw new Exception("amount withdrawed must be higher than zero");
		}
		else if (amount > this.balance)
		{
			throw new Exception("no enough balance");
		}
		else 
		{
			Console.Write($"Withdrawing {amount} ..... ");
			this.balance -= amount;
			return this.balance;
		}
	}
}


}