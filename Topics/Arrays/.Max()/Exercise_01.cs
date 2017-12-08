/********************************************************************
*
*	51. Write a C# program to get the larger value between first
*		and last element of an array (length 3) of integers.
*
*		Test Data:
*		Array1: [1, 2, 5, 7, 8]
*		Highest value between first and last values of the said array: 8
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 14th 2017
*
********************************************************************/
using System;
using System.Linq;


public class Exercise_51
{
	public static void Main()
	{

		/************************
		 *	Jesus' Solution
		 ************************/
		var Array1 = new int[] {1, 2 ,5, 7, 8};
		Console.WriteLine("\nArray1: [{0}]", string.Join(", ", Array1));
		Console.WriteLine("The highest value within Array1 is: {0}", Array1.Max());
		Console.WriteLine("The lowest value within Array1 is: {0}", Array1.Min());


		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		var h_val2 = Array1[0];
		for (var i = 0; i < Array1.Length; i++)
			if (Array1[i] > Array1[0])
				h_val2 = Array1[i];
		Console.WriteLine("The highest value within Array1 is: {0}", h_val2);
		// Lo Mismo Que
		foreach (int n in Array1)
			if (n > Array1[0])
				h_val2 = n;
		Console.WriteLine("The highest value within Array1 is: {0}", h_val2);


		/**************************
		 *	W3resource's Solution
		 **************************/
		int[] nums = {1, 2, 5, 7, 8};
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
        var h_val = nums[0];
        for (var i = 0; i < nums.Length; i++)
        {
			if (nums[i] > nums[0])
            h_val = nums[i];
        }
        Console.WriteLine("\nHighest value between first and last values of the said array: {0}", h_val);
	}
}
