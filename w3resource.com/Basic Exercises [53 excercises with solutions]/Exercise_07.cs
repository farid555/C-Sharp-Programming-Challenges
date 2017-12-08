/********************************************************************
 *
 *	7. Write a program to print on screen the output of
 *     adding, subtractinhg, multiplying and dividing of two numbers
 *	   which will be entered by the user.
 *
 *
 * 	By: Jesus Hilario Hernandez
 * 	Last Updated: October 4th 2017
 *
 ********************************************************************/
using System;

public class Exercise_07
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Input the first number: ");
		var num1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Input the second number: ");
		var num2 = Convert.ToInt32(Console.ReadLine());


		var num3 = num1 + num2;
		Console.WriteLine(num1 + " + " + num2 + " = " + num3);

		num3 = num1 - num2;
		Console.WriteLine(num1 + " - " + num2 + " = " + num3);

		num3 = num1 * num2;
		Console.WriteLine(num1 + " x " + num2 + " = " + num3);

		num3 = num1 / num2;
		Console.WriteLine(num1 + " / " + num2 + " = " + num3);

		num3 = num1 % num2;
		Console.WriteLine(num1 + " mod " + num2 + " = " + num3 + "\n");

		/**************************
		 *	W3resource's Solution
		 **************************/
		Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
		Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
		Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
		Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
		Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);

	}
}
