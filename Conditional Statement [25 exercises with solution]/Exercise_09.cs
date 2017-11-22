/********************************************************************
*
*	09. Write a C# program to accept a coordinate point in an XY
*		coordinate system and determine in which quadrant the coordinate
*		point lies.
*
*		Test Data:
*		Input the value for x:
*		Input the value for y:
*		Expected Output:
*		The coordinate point (7, 9) lies in the First Quadrant.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: November 21th, 2017
*
*
********************************************************************/
using System;

public class Exercise_09
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.Write("Input the value for x: ");
		var x = Convert.ToInt32(Console.ReadLine());
		Console.Write("Input the value for y: ");
		var y = Convert.ToInt32(Console.ReadLine());

		if (x > 0 && y > 0)
			Console.WriteLine("Your coordinate point ({0}, {1}) lies in Quadrant I.", x, y);
		else if (x < 0 && y > 0)
			Console.WriteLine("Your coordinate point ({0}, {1}) lies in Quadrant II.", x, y);
		else if (x < 0 && y < 0)
			Console.WriteLine("Your coordinate point ({0}, {1}) lies in Quadrant III.", x, y);
		else if (x > 0 && y < 0)
			Console.WriteLine("Your coordinate point ({0}, {1}) lies in Quadrant IV.", x, y);
		else
			Console.WriteLine("Your coordinate point ({0}, {1}) lies at the origin.", x, y);
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/
		int co1,co2;

	    Console.Write("\n\n");
	    Console.Write("Find the quadrant in which the coordinate point lies:\n");
	    Console.Write("------------------------------------------------------");
	    Console.Write("\n\n");

     	Console.Write("Input the value for X coordinate :");
	    co1 = Convert.ToInt32(Console.ReadLine());
	    Console.Write("Input the value for Y coordinate :");
	    co2 = Convert.ToInt32(Console.ReadLine());


	 	if( co1 > 0 && co2 > 0)
	 		Console.Write("The coordinate point ({0} {1}) lies in the First quandrant.\n\n",co1,co2);
	 	else if( co1 < 0 && co2 > 0)
	 	  	Console.Write("The coordinate point ({0} {1}) lies in the Second quandrant.\n\n",co1,co2);
	 	else if( co1 < 0 && co2 < 0)
	 	  	Console.Write("The coordinate point ({0} {1}) lies in the Third quandrant.\n\n",co1,co2);
	 	else if( co1 > 0 && co2 < 0)
	 	  	Console.Write("The coordinate point ({0} {1}) lies in the Fourth quandrant.\n\n",co1,co2);
	 	else if( co1 == 0 && co2 == 0)
	 	  	Console.Write("The coordinate point ({0} {1}) lies at the origin.\n\n",co1,co2);
	}
}
