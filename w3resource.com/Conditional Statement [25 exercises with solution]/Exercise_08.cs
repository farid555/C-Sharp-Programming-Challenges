/********************************************************************
*
*	08. Write a C# program that finds the largest of 3 numbers.
*
*		Test Data:
*		Input the 1st number: 25
*		Input the 2nd number: 63
*		Input the 3rd number: 10
*		Expected Output:
*		The 2nd number is the greatest among the three.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: Nov. 7th 2017
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
		Console.Write("Enter 1st number: ");
		var firstNum = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter 2nd number: ");
	 	var secondNum = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter 3rd number: ");
		var thirdNum = Convert.ToInt32(Console.ReadLine());


		var largestNumber = Math.Max(firstNum, Math.Max(secondNum, thirdNum));


		if (largestNumber == firstNum)
			Console.WriteLine("The 1st number is the greatest among the three.");
		else if (largestNumber == secondNum)
			Console.WriteLine("The 2nd number is the greatest among the three.");
		else
			Console.WriteLine("The 3rd number is the greatest among the three.");

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine();
		Console.WriteLine("--- A Second Time ---");
		if (firstNum > secondNum)
		{
			if (firstNum > thirdNum)
				Console.WriteLine("The first number is the greatest # among the three.");
			else
				Console.WriteLine("The third number is greatest among the three.");
		}
		else if (secondNum > thirdNum)
			Console.WriteLine("The second number among the three is greatest.");
		else
			Console.WriteLine("The third number is greatest among the three.");
		/**************************
		 *	W3resource's Solution
		 **************************/
		int num1, num2, num3;
	    Console.Write("\n\n");
	    Console.Write("Find the largest of three numbers:\n");
	    Console.Write("------------------------------------");
	    Console.Write("\n\n");

	    Console.Write("Input the 1st number :");
	    num1 = Convert.ToInt32(Console.ReadLine());
     	Console.Write("Input the  2nd number :");
	    num2 = Convert.ToInt32(Console.ReadLine());
	    Console.Write("Input the 3rd  number :");
	    num3 = Convert.ToInt32(Console.ReadLine());

	   	if (num1 > num2)
	     	{
	         	if (num1 > num3)
	         	{
	             	Console.Write("The 1st Number is the greatest among three. \n\n");
	         	}
	         	else
	         	{
	             	Console.Write("The 3rd Number is the greatest among three. \n\n");
	         	}
	     	}
	    else if (num2 > num3)
	     	Console.Write("The 2nd Number is the greatest among three \n\n");
	    else
	        Console.Write("The 3rd Number is the greatest among three \n\n");
	}
}
