/********************************************************************
*
*	08. Write a C# Sharp program that takes the radius of
*		a sphere as input and calculate and display the
*		surface and volume of the sphere.
*
*		Test Data:
*		Radius: 2
*		Expected Output:
*		50.26548
*		33.51032
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 31st 2017
*
*
********************************************************************/
using System;

public class Exercise_08
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.Write("Radius: ");
		var radius = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Surface = {0}", (4 * 3.14 * (radius * radius)));
		Console.WriteLine("Volume = {0}", ((1.33) * 3.14) * (radius * radius * radius));

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/
		float r;
        float pi = 3.1415926535f;

        Console.Write("Radius: ");
        r = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine( 4 * pi * (r * r) );

        Console.WriteLine( 4f/3f * pi * (r * r * r));
	}
}
