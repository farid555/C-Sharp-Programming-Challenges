/********************************************************************
*
*	45. Write a C# program to count a specified number in a given array
$			of integers.
*
*		Test Data:
*		Input an integer: 5
*		Sample Output
*		Number of 5 present in the said array: 2
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 19th 2017
*
*
********************************************************************/
using System;
using System.Linq;

public class Exercise_45
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		//NADA

		/**************************
		 *	W3resource's Solution
		 **************************/
	  Console.WriteLine("\nInput an integer:");
    int x = Convert.ToInt32(Console.ReadLine());
    int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
    Console.WriteLine("Number of " + x + " present in the said array:");
    Console.WriteLine(nums.Count(n => n == x));
	}


}
