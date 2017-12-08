/********************************************************************
*
*	17. Write a program to create a new string from a given string
*		(length 1 or more) with the first character added at the
* 		front and back.
*
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 6th 2017
*
*
********************************************************************/
using System;

public class Exercise_17
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Input a string: ");

		var firstString = Console.ReadLine();
		var firstLetter = firstString.Substring(0, 1);
		Console.WriteLine(firstLetter + firstString + firstLetter);

		/**************************
		 *	W3resource's Solution
		 **************************/
		string str;
		int l = 0;
		Console.Write("Input a string : ");
		str = Console.ReadLine();
		if (str.Length >= 1)
		{
			var s = str.Substring(0, 1);
			Console.WriteLine(s + str + s);
		}
	}
}
