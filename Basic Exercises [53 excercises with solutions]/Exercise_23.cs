/********************************************************************
*
*	23. Write a program to convert a given string into lowercase.
*
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 11th 2017
*
*
********************************************************************/
using System;

public class Exercise_23
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Enter a string: ");
		var lowercaseString = Convert.ToString(Console.ReadLine()).ToLower();
		Console.WriteLine(lowercaseString.ToLower());
		//Or
		Console.WriteLine("Enter another string: ");
		lowercaseString = Convert.ToString(Console.ReadLine()).ToLower();
		Console.WriteLine(lowercaseString + "\n");


		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		// Nada
		

		/**************************
		 *	W3resource's Solution
		 **************************/
		string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
		Console.WriteLine(line.ToLower());
	}
}
