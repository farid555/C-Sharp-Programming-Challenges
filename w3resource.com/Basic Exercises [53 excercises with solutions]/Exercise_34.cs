/********************************************************************
*
*	34. Write a program to check if a string starts with a specified word.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 14th 2017
*
*
********************************************************************/
using System;


public class Exercise_34
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.Write("Input a string: ");
		var string1 = Convert.ToString(Console.ReadLine());
		// Console.WriteLine(string1.Substring(5) == "Hello");

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine(string1.StartsWith("Hello"));

		/**************************
		 *	W3resource's Solution
		 **************************/
		string str;
           Console.Write("Input a string : ");
           str = Console.ReadLine();

		   var condition1 = (str.Length < 6 && str.Equals("Hello"));
		   var condition2 = (str.StartsWith("Hello") && str[5] == ' ');
           Console.WriteLine(condition1 || condition2);
	}
}
