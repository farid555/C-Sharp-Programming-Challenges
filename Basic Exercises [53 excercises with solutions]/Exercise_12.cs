/********************************************************************
 *
 *	12. Write a program that takes a number as input and displays it
 * 		four times in a row (separated by blank spaces), and then four
 *	    times in the next row, with no separation. You should do it two
 *      times: Use Console.Write and the use {0}.
 *
 * 	By: Jesus Hilario Hernandez
 * 	Last Updated: October 4th 2017
 *
 ********************************************************************/
using System;

public class Exercise_12
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Enter the number 25: ");
		var num = Convert.ToInt32(Console.ReadLine());

		for(var i = 1; i <= 2; i++)
		{
			Console.Write("{0} {0} {0} {0}\n", num);
			Console.Write("{0}{0}{0}{0}\n", num);
		}

	}
}
