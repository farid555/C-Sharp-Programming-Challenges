/********************************************************************
*
*	27. Write a program and compute the sum of the digits of an int.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 13th 2017
*
*
********************************************************************/
using System;

public class Exercise_27
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Enter the first number: ");
		var number1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the second number: ");
		var number2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("The sum of both digits is: " + (number1 + number2));

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine("Enter another number(integer): ");
		var number3 = Convert.ToInt32(Console.ReadLine());
		var sum_2 = 0;
		while (number3 != 0)
		{
			sum_2 += number3 % 10;
			number3 /= 10;
		}
		Console.WriteLine("The sum of your digit is {0}", sum_2);

		/**************************
		 *	W3resource's Solution
		 **************************/
		Console.Write("Input  a number(integer): ");
		int n = Convert.ToInt32(Console.ReadLine());
		int sum = 0;
		while (n != 0)
		{
			sum += n % 10;
			n /= 10;
		}

		Console.WriteLine("Sum of the digits of the said integer: " + sum);
	}
}
