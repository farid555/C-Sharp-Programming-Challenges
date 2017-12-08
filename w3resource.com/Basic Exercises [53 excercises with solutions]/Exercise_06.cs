/********************************************************************
*
*	06. Write a program to print the output of multiplication of
*     3 numbers which will be entered by the user.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 14th 2017
*
*
********************************************************************/
using System;

public class Exercise_06
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Input the first number to multiply: ");
		var num1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Input the second number to multiply: ");
		var num2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Input the third number to multipu: ");
		var num3 = Convert.ToInt32(Console.ReadLine());

		var multiplyAnswer = num1 * num2 * num3;

		Console.Write(num1 + " x ");
		Console.Write(num2 + " x ");
		Console.Write(num3 + " = ");
		Console.WriteLine(multiplyAnswer);

		/**************************
		 *	W3resource's Solution
		 **************************/

	}
}
