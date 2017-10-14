/********************************************************************
*
*	34. Write a program to check two given numbers where one is less
*       than 100 and other is greater than 200.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 14th 2017
*
*
********************************************************************/
using System;


public class Exercise_34
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Enter 1st number(<100): ");
		var number = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter 2nd number(>200): ");
		var number2 = Convert.ToInt32(Console.ReadLine());
		var condition = number < 100 && number2 > 200;

		//if (condition)
		//	Console.WriteLine(condition);
		//else
		//	Console.WriteLine(condition);


		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine(condition + "\n");

		/**************************
		 *	W3resource's Solution
		 **************************/
		Console.Write("Input a first number(<100): ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a second number(>100): ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((m < 100 && n > 200) || (m < 100 && n > 200));
	}
}
