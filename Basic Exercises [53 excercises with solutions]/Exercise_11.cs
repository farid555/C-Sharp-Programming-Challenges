using System;
					
public class Exercise_11
{
	public static void Main()
	{
		
		/******************************************************************** 
		 *
		 *	11. Write a program that takes an age (for example 20) as input
		 *		and prints something as "You look older that 20".
		 *
		 *
		 * 	By: Jesus Hilario Hernandez
		 * 	Last Updated: October 4th 2017
		 *
		 ********************************************************************/
		Console.WriteLine("Enter you age: ");
		var age = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("You look older that {0}.", age);
		
	}
}
