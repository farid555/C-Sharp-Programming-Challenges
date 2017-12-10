/********************************************************************
*
*	48. Write a C# program to check if the first element and the last
*		  element are equal of an array of integers and the length
*			is 1 or more.
*
*		Test Data:
*		Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
*		Sample Output
*		True
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 20th 2017
*
*
********************************************************************/
using System;
using System.Linq;

public class Exercise_48
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		var Array1 = new int[] {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
		// var Array2 = new int[] {0, 0, 0};
		//
		// for (var i = 0; i < Array1.Length; i++)
		// {
		// 	if(Array1[i] == Array1.First() + Array1.Last() && Array1[i] >= 1)
		// 	{
		// 		Array2[i] = Array1[i];
		// 	}
		// 	else
		// 	{
		// 		Console.WriteLine("False");
		// 	}
    	// }
		// Console.WriteLine(Array1.First() + Array1.Last());
		//
		// foreach (int n in Array1)
		// {
		// 	if(n == Array1.First() + Array1.Last() && Array1[n] >= 1)
		// 	{
		// 		Array2[n] = Array1[n];
		// 	}
		// 	else
		// 	{
		// 		Console.WriteLine("False");
		// 	}
		// }
		// ^^^^^^^^^ Too Much obviously. :/ ^^^^^^^^^^^^^^^^


		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine((Array1.Length >= 1) && (Array1.Last().Equals(Array1.Last())));
		Console.WriteLine((Array1.Length >= 1) && (Array1[0] == Array1[Array1.Length - 1]));

		/**************************
		 *	W3resource's Solution
		 **************************/
		int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
        Console.WriteLine((nums.Length >= 1) && (nums[0].Equals(nums[nums.Length - 1])));
	}

}
