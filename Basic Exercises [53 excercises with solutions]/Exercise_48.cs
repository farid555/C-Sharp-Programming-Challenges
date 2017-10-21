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
		var Array2 = new int[] {};

		for (var i = 0; i < Array1.Length; i++)
		{
			if(Array1[i] == Array1.First() + Array1.Last())
			{
				Array2[i] = Array1[i];
			}
    	}



		foreach (int n in Array1)
		{
			if(n == Array1.First() + Array1.Last())
			{
				Array2[] = n;
			}
			else
			{
				Console.WriteLine("False");
			}BackgroundColor
		}

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/

	}

}
