/********************************************************************
*
*	11. Write a C# Sharp program that takes a decimal
*		number as input and displays its
*		equivalent in binary form.
*
*		Test Data:
*		Number to convert (or "end")? 25
*		Expected Output:
*		Binary: 11001
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 31st 2017
*
*
********************************************************************/
using System;

public class Exercise_11
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.Write("Number to convert (or \"end\")? ");
		var numberToConvert = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Binary: {0}", Convert.ToString(numberToConvert, 2));
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/

	}
}
