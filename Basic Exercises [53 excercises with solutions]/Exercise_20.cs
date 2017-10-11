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


		// W3resource Reply

	}

	//public static int result (int a, int b)
	//{

	//}
}
