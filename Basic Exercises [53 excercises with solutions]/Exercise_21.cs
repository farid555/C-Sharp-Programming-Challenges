/********************************************************************
*
*	21. Write a program to check the sum of the two given integers and
*		return true if one of the integers is 20 or if their sum is 20.
*
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 11th 2017
*
*
********************************************************************/
using System;

public class Exercise_21
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		var num1 = 29;
		var num2 = 65;
		if (num1 == 20 || num2 == 20 || num1 + num2 == 20)
			Console.WriteLine("True");
		else
			Console.WriteLine("False");

		/**************************
		 *	W3resource's Solution
		 **************************/

		int x, y;
		Console.WriteLine("\nInput an integer:");
		x = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Input another integer:");
		y = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(x == 20 || y == 20 || (x + y == 20));
	}
}
