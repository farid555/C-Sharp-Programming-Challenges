/********************************************************************
*
*	49. Write a C# program to check if the first element or the last
*		element of the two arrays ( length 1 or more) are equal.
*
*		Test Data:
*		Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
*		Array2: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5]
*		Check if the first element or the last element of the
*		two arrays (length 1 or more) are equal.
*		Sample Output
*		True
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 22th 2017
*
*
********************************************************************/
using System;
using System.Linq;

public class Exercise_49
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		var Array1 = new int[] {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
		var Array2 = new int[] {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5};
		Console.WriteLine((Array1.Length >= 1) && (Array1.First().Equals(Array1[Array1.Length -1])) || (Array2.First().Equals(Array2[Array2.Length -1])));

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine("\nArray1: [{0}]", String.Join(", ", Array1));
		Console.WriteLine("\nArray2: [{0}]", String.Join(", ", Array2));
		Console.WriteLine("\nCheck if the first element of the last element of the two arrays (length 1 or more) are equal.");

		Console.WriteLine((Array1[0] == Array2[0]) || Array1[Array1.Length - 1] == Array2[Array2.Length - 1]);
		// LO MISMO
		Console.WriteLine((Array1[0].Equals(Array2[0])) || (Array1[Array1.Length - 1].Equals(Array2[Array2.Length - 1])));
		// LO MISMO
		Console.WriteLine((Array1.First().Equals(Array2.First())) || (Array1.Last().Equals(Array2.Last())));

		/**************************
		 *	W3resource's Solution
		 **************************/
		 int[] nums1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
         Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums1));
         int[] nums2 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5};
         Console.WriteLine("\nArray2: [{0}]", string.Join(", ", nums2));

         Console.WriteLine("\nCheck if the first element or the last element of the two arrays ( length 1 or more) are equal.");
         Console.WriteLine((nums1[0].Equals(nums2[0])) || (nums1[nums1.Length - 1].Equals(nums2[nums2.Length - 1])));
	}

}
