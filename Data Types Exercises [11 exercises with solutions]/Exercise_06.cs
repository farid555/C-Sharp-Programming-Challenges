/********************************************************************
*
*	06. Write a C# Sharp program to display certain values of the 
*		function x = y2 + 2y + 1 (using integer numbers for y , 
*		ranging from -5 to +5).
*
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 26th 2017
*
*
********************************************************************/
using System;

public class Exercise_06
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine(equation(9));
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/
	
	}
	public static int equation(int y)
	{
		int x = 9;
		for (var i = -5; i <= 5; i++)
		{
			x = (y * y) + (2 * y) + 1;
			Console.WriteLine(x);
			x++;
		}
	return x;	
	}
}
