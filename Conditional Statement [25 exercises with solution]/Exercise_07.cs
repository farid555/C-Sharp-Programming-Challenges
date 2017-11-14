/********************************************************************
*
*	07. Write a C# Sharp program to accept the height of a person in
*		centimeter and categorize the person according to their height.
*
*		Test Data : 135
*		Expected Output:
*		The person is Darf.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: November 6th 2017
*
*
********************************************************************/
using System;

public class Exercise_07
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("How tall are you -- in centimeters?");
		var personsHeight = Convert.ToInt32(Console.ReadLine());

		if (personsHeight < 135)
			Console.WriteLine("According to your height, you are a dwarf.");
		else
			Console.WriteLine("According to your height, you are not a dwarf.");

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/

	}
}
