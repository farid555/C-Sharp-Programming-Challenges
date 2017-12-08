/********************************************************************
*
*	04. Write a C# Sharp program to find whether a given year
*	 	is a leap year or not.
*
*		Test Data : 2016
*		Expected Output :
*		2016 is a leap year.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: November 1st 2017
*
********************************************************************/
using System;

public class Exercise_04
{
	public static void Main()
	{
		/**************************
		 *	W3resource's Solution
		 **************************/
		int chk_year;
     	Console.Write("\n\n");
     	Console.Write("Check whether a given year is leap year or not:\n");
     	Console.Write("----------------------------------------------");
     	Console.Write("\n\n");
     	Console.Write("Input an year : ");
     	chk_year= Convert.ToInt32(Console.ReadLine());

     	if ((chk_year % 400) == 0)
  			Console.WriteLine("{0} is a leap year.\n", chk_year);
     	else if ((chk_year % 100) == 0)
  			Console.WriteLine("{0} is not a leap year.\n", chk_year);
     	else if ((chk_year % 4) == 0)
  			Console.WriteLine("{0} is a leap year.\n", chk_year);
     	else
  			Console.WriteLine("{0} is not a leap year.\n", chk_year);

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.Write("Input a year: ");
		var year = Convert.ToInt32(Console.ReadLine());

		var notALeapYear = "{0} is not a leap year.";

		
		if ((year % 400) == 0 || (year % 4) == 0)
			Console.WriteLine("{0} is a leap year.", year);
		else if ((year % 100) == 0)
			Console.WriteLine(notALeapYear, year);
		else
			Console.WriteLine(notALeapYear, year);
	}
}
