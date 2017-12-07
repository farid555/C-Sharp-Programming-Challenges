/********************************************************************
*
*	46. Write a C# program to check if a number appears as
*			either the first or last element of an array of
*			integers and the length is 1 or more.
*
*		Test Data:
*		Input an integer: 25
*		Sample Output
*		False
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 19th 2017
*
*
********************************************************************/
using System;
using System.Linq;

public class Exercise_46
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		int[] numberArray = {1, 5, 7, 9, 11, 6, 2, 3, 4, 10, 8, 12};
		Console.Write("Input an integer: ");
		var integer = Convert.ToInt32(Console.ReadLine());
		var boolean = (integer == numberArray.Last() || integer == numberArray.First());
		if (boolean)
			Console.WriteLine(boolean);
		else
			Console.WriteLine(boolean);

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine(boolean);

		/**************************
		 *	W3resource's Solution
		 **************************/
		Console.WriteLine("\nInput an integer: ");
		int x = Convert.ToInt32(Console.ReadLine());
		int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
		Console.WriteLine((nums[0] == x) || (nums[nums.Length -1] == x));
	}

}
