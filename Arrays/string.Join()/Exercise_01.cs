/********************************************************************
*
*	31. Write a program to multiply corresponding elements of two
*		arrays of integers.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 13th 2017
*
*
********************************************************************/
using System;


public class Exercise_31
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		var array1 = new int[4] {1, 3, -5, 4};
		var array2 = new int[4] {1, 4, -5, -2};
		var array3 = new int[4];

		for (var i = 0; i < array1.Length; i++)
		{
			array3[i] = array1[i] * array2[i];
		}

		Console.WriteLine("Array1: [1, 3, -5, 4]");
		Console.WriteLine("Array1: [1, 4, -5, -2]");
		Console.WriteLine("Multiply corresponding elements of two arrays: ");
		foreach (var sumTots in array3)
		{
			Console.Write("{0} ", sumTots);
		}

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine("\n\nArray1: [{0}]", string.Join(", ", array1));

		/**************************
		 *	W3resource's Solution
		 **************************/
		int[] first_array = {1, 3, -5, 4};
     	int[] second_array = {1, 4, -5, -2};

      	Console.WriteLine("\n\nArray1: [{0}]", string.Join(", ", first_array));
      	Console.WriteLine("Array2: [{0}]", string.Join(", ", second_array));

      	Console.WriteLine("Multiply corresponding elements of two arrays: ");

     	for (int i = 0; i < first_array.Length; i++)
        {
         	Console.Write(first_array[i] * second_array[i]+" ");
        }
     	Console.WriteLine("\n");
	}
}
