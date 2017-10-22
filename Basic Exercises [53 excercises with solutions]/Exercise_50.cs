/********************************************************************
*
*	50. Write a C# program to rotate an array (length 3) of integers in
*		left direction.
*
*		Test Data:
*		Array1: [1, 2, 8]
*		After rotating array becomes: [2, 8, 1]
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 14th 2017
*
*
********************************************************************/
using System;


public class Exercise_50
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		var Array1 = new int[] {1, 2, 8};
		// Array.Reverse(Array1);
		// Console.WriteLine("Array1: [{0}]", string.Join(", ", Array1));

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine("\nArray1: [{0}]", string.Join(", ", Array1));
		var temp2 = Array1[0];
		// for (var i = 0; i < 2; i++) // 2 Same as Array.Length - 1;
		for (var i = 0; i < Array1.Length - 1; i++) // Array.Length - 1 Same as 2;
			Array1[i] = Array1[i + 1];
		Array1[Array1.Length - 1] = temp2;
		Console.WriteLine("\nAfter rotating, the array becomes: [{0}]", string.Join(", ", Array1));

		/**************************
		 *	W3resource's Solution
		 **************************/
		int[] nums = {1, 2, 8};
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
        var temp = nums[0];
        for (var i = 0; i < nums.Length - 1; i++)
        {
         	nums[i] = nums[i + 1];
        }
    	nums[nums.Length - 1] = temp;
       	Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));
	}
}
