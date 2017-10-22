/********************************************************************
 *
 *	10. Write a program that takes three numbers(x,y,z)
 *	   as input and print the output of (x+y)*z and x*y + y*z.
 *
 *
 * 	By: Jesus Hilario Hernandez
 * 	Last Updated: October 4th 2017
 *
 ********************************************************************/
using System;

public class Exercise_10
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Enter the number 5 as x: ");
		var x = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the number 6 as y: ");
		var y = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the number 7 as z:  ");
		var z = Convert.ToInt32(Console.ReadLine());

		Console.Write("Result of specified numbers ");
		Console.WriteLine("{0}, {1}, and {2}", x, y, z);

		Console.Write("as x, y ,z in (x + y) * z is ");
		Console.WriteLine("{0} ", (x + y) * z);

		Console.Write("and in (x*y + y*z) is ");
		Console.WriteLine("{0}.", (x*y + y*z));

	}
}
