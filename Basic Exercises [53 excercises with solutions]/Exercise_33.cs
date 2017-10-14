/********************************************************************
*
*	33. Write a program to check if a given number is a multiple of 3
*		or a multiple of 7.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 13th 2017
*
*
********************************************************************/
using System;


public class Exercise_33
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Input your first integer: ");
		var number = Convert.ToInt32(Console.ReadLine());
		if (number % 3 == 0)
			Console.WriteLine(number % 3 == 0);
		else
			Console.WriteLine(number % 3 == 0);


		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		var cond = number % 3 == 0 || number % 7 == 0 || number > 0;
		if (cond)
			Console.WriteLine(cond);

		/**************************
		 *	W3resource's Solution
		 **************************/
		Console.WriteLine("\nInput first integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x > 0)
        {
			Console.WriteLine(x % 3 == 0 || x % 7 == 0);
        }
	}
}
