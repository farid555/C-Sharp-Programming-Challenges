/********************************************************************
*
*	03. Write a C# Sharp program that takes user id and 
*		password as input (type string). After 3 wrong 
*		attempts, user will be rejected. 
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 25th 2017
*
*
********************************************************************/
using System;

public class Exercise_03
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		// Console.WriteLine("Enter a user id: ");
		// var userId = Convert.ToString(Console.ReadLine());
		// Console.WriteLine("Enter a user id: ");
		// var userPassword = Convert.ToString(Console.ReadLine());
		
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		var key = "password"; 
		string userId, userPassword;
		int counter = 0;
		bool counterBool;
		do
		{
			Console.WriteLine("Enter a user id: ");
			userId = Convert.ToString(Console.ReadLine());
			Console.WriteLine("Enter a password: ");
			userPassword = Convert.ToString(Console.ReadLine());
			if (userId == key && userPassword == key)
			{
				counter = 3; 
				counterBool = true;
			}			
			else
			{
				counter++;
				counterBool = false;
			}
				
		} while ((userId != key || userPassword != key) && (counter != 3));
		if (counterBool)
			Console.WriteLine("Correct User Id and Password");
		else
			Console.WriteLine("Login attemt more that three times. Try again later.");
		
		/**************************
		 *	W3resource's Solution
		 **************************/
		string username, password;
		int ctr = 0, dd = 0;
		Console.Write("\n\nCheck username and password :\n");
		Console.Write("N.B. : Defaule username and password is : username and password\n");
		Console.Write("---------------------------------\n");
		do
		{
			Console.Write("Input a username: ");
			username = Console.ReadLine();
			Console.Write("Input a password: ");
			password = Console.ReadLine();
			if (username == "username" && password == "password")
			{
				dd = 1;
				ctr = 3;
			}
			else
			{
				dd = 0;
				ctr++;
			}
		}
		while ((username != "username" || password != "password") && (ctr != 3));
		if (dd == 0)
		{
			Console.Write("\nLogin attemp more than three times. Try later!\n\n");
		}
		else if (dd == 1)
		{
			Console.Write("\nPassword entered successfull!\n\n");
		}
	}
}
