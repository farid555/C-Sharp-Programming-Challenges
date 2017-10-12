/********************************************************************
*
*	22. Write a program to check if an integer is within 20 of 100 or 200
*
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 11th 2017
*
*
********************************************************************/
using System;

public class Exercise_22
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Enter your 1st integer: ");
		var number_1 = Convert.ToInt32(Console.ReadLine());

		var condition = number_1 >= 20 && number_1 <= 100 || number_1 == 200;

		if (condition)
			Console.WriteLine(condition + "\n"); // True
		else
			Console.WriteLine(condition + "\n"); // False
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine("Enter your 1st integer: ");
		number_1 = Convert.ToInt32(Console.ReadLine());
		var condition2 = Math.Abs(number_1 - 100) <= 20 || Math.Abs(number_1 - 200) <= 20;
		if (condition2)
			Console.WriteLine(condition2);
		else
			Console.WriteLine(condition2);


		/**************************
		 *	W3resource's Solution
		 **************************/
		Console.WriteLine("\nInput an integer:");
		int x = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(result(x));
	}

	public static bool result(int n)
	{
		if (Math.Abs(n - 100) <= 10 || Math.Abs(n - 200) <= 10)
			return true;
		return false;
	}
}
