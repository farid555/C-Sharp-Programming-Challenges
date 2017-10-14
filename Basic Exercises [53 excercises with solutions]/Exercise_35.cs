/********************************************************************
*
*	36. Write a program to check if an integer (from the two given
*		integers) is in the range -10 to 10.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 14th 2017
*
*
********************************************************************/
using System;

public class Exercise_36
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.Write("Input a first number: ");
		var number = Convert.ToInt32(Console.ReadLine());
		Console.Write("Input a second number: ");
		var number2 = Convert.ToInt32(Console.ReadLine());
		//Console.WriteLine((number > -10 && number < 10) || (number2 > -10 && number2 < 10));
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine((number >= -10 && number <= 10) || (number2 >= -10 && number2 <= 10));
		/**************************
		 *	W3resource's Solution
		 **************************/
		Console.Write("Input a first number: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a second number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(((m >= -10 && m <= 10)) || ((n >= -10 && n <= 10)));
	}
}
