/******************************************************************** 
*
*	18. Write a program that checks two given integers and return true
*		if one is negative and on is positive.
*
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 6th 2017
*
*
********************************************************************/
using System;

public class Exercise_18
{
	public static void Main()
	{
		Console.WriteLine("Input the first integer: ");
		var firstInt = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Input the second integer: ");
		var secondInt = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Check if one value is negative and the other value is positive: ");
		
		// WRONG!
		if ((firstInt > 0 || firstInt < 0) && (secondInt > 0 || secondInt < 0))
			Console.WriteLine("True");
		else
			Console.WriteLine("False");
		
		// RIGHT: notice Logical Operator change and string variable changes
		if ((firstInt > 0 && secondInt < 0) || (firstInt < 0 && secondInt > 0))
			Console.WriteLine("True");
		else
			Console.WriteLine("False");
		
		
		/*****************************
		 *	W3resource's Solution
		 *****************************/
		Console.WriteLine("\nInput first integer:");
		int x = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Input second integer:");
		int y = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Check if one is negative and one is positive:");
		Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
	}
}
// Resources used:
// 1. https://www.tutorialspoint.com/csharp/csharp_logical_operators.htm
// 2. https://www.w3resource.com/csharp-exercises/basic/csharp-basic-exercise-18.php
