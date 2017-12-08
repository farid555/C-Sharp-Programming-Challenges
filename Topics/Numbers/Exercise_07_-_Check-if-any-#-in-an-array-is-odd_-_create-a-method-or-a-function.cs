/********************************************************************
*
*	53. Write a C# program to check if an array contains an odd number.
*
*		Test Data:
*		Original array: [2, 4, 7, 8, 6]
*		Check if an array contains an odd number? True
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 22th 2017
*
********************************************************************/
using System;


public class Exercise_53
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		var Array1 = new int[] {2, 4, 7, 8, 6};
		Console.WriteLine("\nOriginal array: [{0}]", string.Join(", ", Array1));
		 /*******************************************
 		 *	Jesus' Solution After checking response
 		 *******************************************/
		Console.WriteLine("Check if an array has on odd number?" + checkIfOdd(Array1));

		/**************************
		 *	W3resource's Solution
		 **************************/
		int [] nums = {2, 4, 7, 8, 6};
		Console.WriteLine("\nOriginal array: [{0}]", string.Join(", ", nums));
		Console.WriteLine("Check if an array contains an odd number? " + even_odd(nums));
	}
	
	public static bool even_odd(int[] nums)
	{
		foreach (var n in nums)
		{
			if(n % 2 != 0)
				return true;
		}
		return false;
	}
	/********************************************
 	 *	Jesus' Methods After checking response	*
 	 ********************************************/
	public static bool checkIfOdd(int[] arrayNums)
	{
		foreach(var n in arrayNums)
			if (n % 2 != 0)
				return true;
		return false;
	}
}
