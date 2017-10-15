/********************************************************************
*
*	40. Write a C# program to check the nearest value of 20 of two
*		given integers and return 0 if two numbers are same.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 14th 2017
*
*
********************************************************************/
using System;


public class Exercise_40
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Input first integer: ");
		var num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Input second integer: ");
		var num2 = Convert.ToInt32(Console.ReadLine());

		//if (num1 )
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		//Console.WriteLine(Math.Abs(num1 - 20));
		if (num1 == num2)
 			Console.WriteLine(0);
		else if ((num1 - 20) < (num2 - 20))
			Console.WriteLine(num1);
		else
			Console.WriteLine(num2);
		/**************************
		 *	W3resource's Solution
		 **************************/
		Console.WriteLine("\nInput first integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int y = Convert.ToInt32(Console.ReadLine());
        int n = 20;
        var val1 = Math.Abs(x - n);
        var val2 = Math.Abs(y - n);
        Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
	}
}
