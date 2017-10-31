/********************************************************************
*
*	06. Write a C# Sharp program to display certain values of the
*	    function x = y2 + 2y + 1 (using integer numbers for y ,
*	    ranging from -5 to +5).
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
		for (var i = -5; i <= 5; i++)
		{
			var x2 = (i * i) - (2 * i) + 1;
			// Console.Write("y = {0}; ", i);
			Console.WriteLine("x = {0}\xB2  + 2({0}) + 1 = {1}; While y = {0}", i, x2);

		}

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine();

		/**************************
		 *	W3resource's Solution
		 **************************/
		int x, y;

        Console.WriteLine("x = y² - 2y +1");
        Console.WriteLine();

       	for (y=-5; y <= 5; y++)
        {
						x = y*y - 2*y + 1;
            Console.WriteLine(
            "y = {0} ; x=({0})² - 2*({0}) +1 = {1}", y, x);
        }
	}
}
