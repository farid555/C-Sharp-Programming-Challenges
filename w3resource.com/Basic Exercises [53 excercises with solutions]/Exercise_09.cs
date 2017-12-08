/********************************************************************
 *
 *	9. Write a program that takes four numbers as input to calculate
 * 	   calculate and print the average.
 *
 *
 * 	By: Jesus Hilario Hernandez
 * 	Last Updated: October 4th 2017
 *
 ********************************************************************/
using System;

public class Exercise_09
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Enter the First number: 10");
		var num1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the Second number: 15");
		var num2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the Third number: 20");
		var num3 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the Fourth number: 30");
		var num4 = Convert.ToInt32(Console.ReadLine());

		Console.Write("The average of ");
		Console.Write("{0}, {1}, {2}, and {3} is: ", num1, num2, num3, num4);
		Console.WriteLine("{0}", (num1 + num2 + num3 + num4) / 4);

	}
}
