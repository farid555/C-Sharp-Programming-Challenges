/********************************************************************
*
*	05. Write a C# Sharp program that takes the radius of a circle as
*		input and calculate the perimeter and area of the circle.
*
*		Test Data
*		Input the radius of the circle :
*		12
*		Expected Output :
*		Perimeter of Circle : 75.36
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
