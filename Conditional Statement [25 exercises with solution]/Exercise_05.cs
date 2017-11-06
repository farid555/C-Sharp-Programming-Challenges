/********************************************************************
*
*	05. Write a C# Sharp program to read the age of a candidate and 
*		determine whether it is eligible for casting his/her own vote.
*
*		Test Data : 21 
*		Expected Output:
*		Congratulation! You are eligible for casting your vote.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: November 6th 2017
*
*
********************************************************************/
using System;

public class Exercise_05
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Let's see if you are eligible to vote.");
		Console.Write("How old are you? ");
		var personsAge = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine(personsAge >= 18 ? "Congrats! You are eligible to vote" : "You are NOT eligible to vote");
		
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/

	}
}
