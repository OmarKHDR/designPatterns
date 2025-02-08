using System;

class DataBase
{
	public void SaveData(string database, string data)
	{
		connect(database);
		save(data);
		disconnect();
	}

	private void connect(string database)
	{
		Console.WriteLine($"connecting to {database} database....");
	}

	private void save(string data)
	{
		Console.WriteLine("saving data");
	}

	private void disconnect()
	{
		Console.WriteLine("disconnecting....");
	}
}