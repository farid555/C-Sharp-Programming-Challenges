/********************************************************************
*
*	20. Write a program to get the absolute value of the difference
*	    between two given numbers. Return double the absolute value
*		of the difference if the first number is greater than second
*		number.
*
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 11th 2017
*
*
********************************************************************/
using System;

public class Exercise_20
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Enter first number: ");
		var num1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter second number: ");
		var num2 = Convert.ToInt32(Console.ReadLine());

		if (num1 > num2)
		{
			Console.WriteLine("(" + num1 + " - " + num2 + ")" + " x " + 2 + " = " + (num1 - num2) * 2);
		}
		else
		{
			Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
		}

		result2(26, 5);
		result2(67, 90);
		result2(5, 23);

		/**************************
		 *	W3resource's Solution
		 **************************/

		Console.WriteLine(result(13, 40));
		Console.WriteLine(result(50, 21));
		Console.WriteLine(result(0, 23));
	}

	public static int result (int a, int b)
	{
		if (a > b)
			return (a - b) * 2;
		return b - a;
	}

	/***************************
	 *	Jesus' Solution Methods
	 ***************************/
	public static void result2 (int x, int y)
	{
		Console.WriteLine("Enter first number: ");
		x = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter second number: ");
		y = Convert.ToInt32(Console.ReadLine());

		if (x > y)
		{
			Console.WriteLine("(" + x + " - " + y + ")" + " x " + 2 + " = " + (x - y) * 2);
		}
		else
		{
			Console.WriteLine(x + " - " + y + " = " + (x - y));
		}


	}
}
