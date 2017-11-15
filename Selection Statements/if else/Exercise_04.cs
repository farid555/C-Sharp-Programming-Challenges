/********************************************************************
*
*	03. Write a C# Sharp program to check whether a given number
*		is positive or negative.
*
*		Test Data : 14
*		Expected Output :
*		14 is a positive number
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: November 1st 2017
*
********************************************************************/
using System;

public class Exercise_03
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.Write("Input number: ");
		var number = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(number > 0 ? "{0} is a positive number. " : "{0} is a negative #.", number);

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		if (number >= 0)
			Console.WriteLine("{0} is a positive #: ", number);
		else
			Console.WriteLine("{0} is a negative #: ", number);

		/**************************
		 *	W3resource's Solution
		 **************************/
		int num;
      	Console.Write("\n\n");
     	Console.Write("Check whether a number is positive or negative:\n");
     	Console.Write("----------------------------------------------");
     	Console.Write("\n\n");
     	Console.Write("Input an integer : ");
     	num= Convert.ToInt32(Console.ReadLine());
     	if (num >= 0)
			Console.WriteLine("{0} is a positive number.\n",num);
     	else
         	Console.WriteLine("{0} is a negative number. \n", num);
	}
}
