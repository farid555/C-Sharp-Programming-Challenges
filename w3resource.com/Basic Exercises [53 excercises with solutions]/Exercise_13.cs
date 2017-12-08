/**********************************************************************
 *
 *	13. Write a program that takes a character as input and then displays
 *	 	a rectangle of 3 columns wide and 5 rows tall using that digit.
 *
 * 	By: Jesus Hilario Hernandez
 * 	Last Updated: October 4th 2017
 *
 **********************************************************************/
using System;

public class Exercise_13
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Enter a character: ");
		var character = Convert.ToChar(Console.ReadLine());


		Console.WriteLine("{0}{0}{0}", character);
		for (var i = 0; i <= 2; i++)
		{
			Console.WriteLine("{0} {0}", character);
		}
		Console.WriteLine("{0}{0}{0}", character);

	}
}
