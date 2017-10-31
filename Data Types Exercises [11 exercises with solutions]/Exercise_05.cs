/********************************************************************
*
*	05. Write a C# Sharp program to display certain values of the
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

public class Exercise_05
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Input the radius of a circle:");
		var radius = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Expected Output: \nPerimeter of Circle: {0}", (2 * 3.14 * radius));

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/
		double r,per_cir;
    double PI = 3.14;
    Console.WriteLine("Input the radius of the circle : ");
    r = Convert.ToDouble(Console.ReadLine());
    per_cir = 2 * PI * r;
    Console.WriteLine("Perimeter of Circle : {0}", per_cir);
    //Console.ReadLine();

	}
}
