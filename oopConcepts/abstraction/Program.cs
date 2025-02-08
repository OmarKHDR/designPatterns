using System;
/*
* Abstraction: hide low level details and allowing only access
*			   through high level method to simplify user interface
*
* - sending emails contains many low level details like: connecting, authentication, sending the email
* allowing user to send email using one high level method "SendEmail" simplifies api, reduces
* the code that needs to be modified if the low level details where modified
* - storing into a database should have a high level function that abstract user interface to not
* worry about the database type itself
*/

class Abstraction
{
	static void Main()
	{
		DataBase db = new DataBase();
		db.SaveData("mongodb", "name=omar");
	}

}