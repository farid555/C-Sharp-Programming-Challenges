/********************************************************************
*
*	47. Write a C# program to compute the sum of all the
*			elements of an array of integers.
*
*		Test Data:
*		Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
*		Sample Output
*		Sum: 69
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 20th 2017
*
*
********************************************************************/
using System;
using System.Linq;

public class Exercise_47
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		var Array1 = new int[] {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
		Console.WriteLine("Sum: {0}", Array1.Sum());

		var sum = 0;
		foreach (int n in Array1)
			sum += n;
		Console.WriteLine("Sum: {0}", sum);

		var sum2 = 0;
		for (var i = 0; i < Array1.Length; i++)
			sum2 += Array1[i];
		Console.WriteLine("Sum: {0}", sum2);
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine("\nArray1: [{0}]", string.Join(", ", Array1));
		Console.WriteLine("\n");

		/**************************
		 *	W3resource's Solution
		 **************************/
		int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
		Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
		var sum3 = 0;
			for (var i = 0; i < nums.Length; i++)
			{
				sum3 += nums[i];
			}
			Console.WriteLine("Sum: " + sum3);
	}

}
