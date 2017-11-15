/********************************************************************
*
*	02. Write a C# Sharp program to check whether a given number is
*		even or odd.
*
*		Test Data : 15
*		Expected Output :
*		15 is an odd integer
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 25th 2017
*
*
********************************************************************/
using System;

public class Exercise_02
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		var number = 15;
		Console.WriteLine("Test Data: " + number);
		Console.WriteLine("Expected Output: ");
		Console.WriteLine(number % 2 != 0 ? number + " is an odd int" : number + " is an even integer");
		Console.WriteLine();

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.Write("Enter an integer to check if even or odd: ");
		var userNum = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(userNum % 2 == 0 ? userNum + " is an even #." : userNum + " is an odd #.");
		/**************************
		 *	W3resource's Solution
		 **************************/
		int num1, rem1;
     	Console.Write("\n\n");
     	Console.Write("Check whether a number is even or odd :\n");
     	Console.Write("---------------------------------------");
     	Console.Write("\n\n");
     	Console.Write("Input an integer : ");
     	num1= Convert.ToInt32(Console.ReadLine());
     	rem1 = num1 % 2;
     	if (rem1 == 0)
  			Console.WriteLine("{0} is an even integer.\n",num1);
     	else
  			Console.WriteLine("{0} is an odd integer.\n",num1);
	}
}
