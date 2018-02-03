/********************************************************************
*
*	20. Write a program in C# Sharp to read any day number in
*		integer and display day name in the word.
*
*		Test Data :
*		4
*		Expected Output :
*		Thursday
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: Dec. 21st 2017
*
*
********************************************************************/
using System;

public class Exercise_20
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		switch (day_number) {
			case 1:
				Console.WriteLine("Monday");
				break;
			case 2:
				Console.WriteLine("Tuesday");
				break;
			case 3:
				Console.WriteLine("Wednesday");
				break;
			case 4:
				Console.WriteLine("Thursday");
				break;
			case 5:
				Console.WriteLine("Friday");
				break;
			case 6:
				Console.WriteLine("Saturday");
				break;
			case 7:
				Console.WriteLine("Sunday");
				break;
		}
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/

	}
}
