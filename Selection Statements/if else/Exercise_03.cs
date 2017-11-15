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
		int vote_age;
    	Console.Write("\n\n");
    	Console.Write("Detrermine a specific age is eligible for casting the vote:\n");
    	Console.Write("----------------------------------------------------------");
    	Console.Write("\n\n");


    	Console.Write("Input the age of the candidate : ");
    	vote_age= Convert.ToInt32(Console.ReadLine());
  		if (vote_age<18)
     	{
       		Console.Write("Sorry, You are not eligible to caste your vote.\n");
       		Console.Write("You would be able to caste your vote after {0} year.\n\n",18-vote_age);
     	}
  		else
     		Console.Write("Congratulation! You are eligible for casting your vote.\n\n");
		
	}
}
