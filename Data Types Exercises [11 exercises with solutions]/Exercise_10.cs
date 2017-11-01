/********************************************************************
*
*	10. Write a C# Sharp program that takes two numbers as
*		input and returns true or false when both
*		numbers are even or odd.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 31st 2017
*
*
********************************************************************/
using System;

public class Exercise_10
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.Write("Enter your first number: ");
		var firstNumber = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter your second #: ");
		var secondNumber = Convert.ToInt32(Console.ReadLine());

		var condition = (firstNumber % 2 == 0) && (secondNumber % 2 == 0) || (firstNumber % 2 != 0) && (secondNumber % 2 != 0);

		if (condition)
			Console.WriteLine(condition);
		else
			Console.WriteLine(condition);

		Console.WriteLine();
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/
		int n1, n2;
	    bool bothEven;
	    Console.Write("Input First number: ");
	    n1 = Convert.ToInt32(Console.ReadLine());
	    Console.Write("Input Second number: ");
	    n2 = Convert.ToInt32(Console.ReadLine());

	    //bothEven = ((n1%2!=0) || (n1%2!=0))? false:true;
	    bothEven = ((n1 % 2 == 0) && (n2 % 2 ==0)) ? true : false;

	 	Console.WriteLine(bothEven ? "there're numbers bothEven" : "there's a number odd");
	}
}
