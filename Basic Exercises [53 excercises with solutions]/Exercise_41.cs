/********************************************************************
*
*	41. Write a C# program to check if a given string contains ‘w’
*			character between 1 and 3 times.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 14th 2017
*
*
********************************************************************/
using System;
using System.Linq;

public class Exercise_41
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.Write("Input a string (contains at least one 'w' char): ");
		var string1 = Convert.ToString(Console.ReadLine());
		Console.Write("Test the string contains 'w' character between 1 and 3 times: ");
		//var string2 = Convert.ToInt32(Console.ReadLine());

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		var numberOfLetters = string1.Count(s1 => s1 == 'e');
		Console.WriteLine(numberOfLetters);

		/**************************
		 *	W3resource's Solution
		 **************************/
		Console.Write("Input a string (conatins at least one 'w' char) : ");
	  	string str = Console.ReadLine();
	  	var count = str.Count(s => s == 'e');
	  	Console.WriteLine("Test the string contains 'w' character  between 1 and 3 times: ");
	  	Console.WriteLine(count>=1 && count <= 3);

	}
}
