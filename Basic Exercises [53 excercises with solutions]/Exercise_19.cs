/********************************************************************
*
*	19. Write a program to compute the sum of two given integers, if
*		two values are equal then return the triple of their sum.
*
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 10th 2017
*
*
********************************************************************/
using System;

public class Exercise_19
{
	public static void Main()
	{
		Console.WriteLine("Enter your first number: ");
		var firstNumber = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter you second number: ");
		var secondNumber = Convert.ToInt32(Console.ReadLine());

		if (firstNumber == secondNumber)
		{
			Console.Write("Your sum tripled is: ");
			Console.WriteLine((firstNumber + secondNumber) * 3);
		}
		else
			Console.WriteLine("Your sum is: " + (firstNumber + secondNumber));

		var tripled = "Your sum tripled is: " + (firstNumber + secondNumber) * 3;
		var sumed =  "Your sum is: " + (firstNumber + secondNumber);
		var sum = firstNumber == secondNumber ?  tripled : sumed;

		Console.WriteLine(sum);

		/**************************
		 *	W3resource's Solution
		 **************************/
		Console.WriteLine(SumTriple(2,2));
        Console.WriteLine(SumTriple(12,10));
        Console.WriteLine(SumTriple(-5,2));
	}

	public static int SumTriple(int a, int b)
    {
   		return a == b ? (a + b)*3 : a + b;
    }
}
