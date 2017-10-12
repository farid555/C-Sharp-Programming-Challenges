/********************************************************************
*
*	25. Write a program to print the odd numbers from 1 to 99. Print
*		one # per line.
*
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 12th 2017
*
*
********************************************************************/
using System;

public class Exercise_25
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		for (var i = 1; i <= 99; i += 2)
			Console.WriteLine(i);

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine("\nOdd numbers from 1 to 99. Prints one # per line.");
		for (var i = 1; i < (99 + 1); i++)
		{
			if (i % 2 != 0)
				Console.WriteLine(i.ToString());
		}
		Console.WriteLine();
		/**************************
		 *	W3resource's Solution
		 **************************/
		Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
		for (int n = 1; n < (99 + 1); n++)
		{
			if (n % 2 != 0)
			{
				Console.WriteLine(n.ToString());
			}
		}
	}
}
