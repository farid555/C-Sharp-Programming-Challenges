/********************************************************************
*
*	50. Write a C# program to reverse the numbers in an array.
*
*		Test Data:
*		Array1: [1, 2, 8]
*		Array1 Reversed: [8, 2, 1]
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: November 29th 2017
*
*
********************************************************************/
using System;


public class Exercise_50
{
	public static void Main()
	{

		var Array1 = new int[] {1, 2, 8};
 		Console.WriteLine("Array1: [{0}]", string.Join(", ", Array1));
 		Array.Reverse(Array1);
 		Console.WriteLine("Array1 Reversed: [{0}]", string.Join(", ", Array1));

	}
}
