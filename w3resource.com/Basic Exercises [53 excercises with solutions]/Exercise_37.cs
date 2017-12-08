/********************************************************************
*
*	37. Write a program to check if "HP" appears at second position
*		in a string and returns the string without "HP".
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 14th 2017
*
*
********************************************************************/
using System;


public class Exercise_37
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		var string1 = "PHP Tutorial";
		if (string1.Substring(1, 2) == "HP")
			Console.WriteLine(string1.Remove(1, 2));
		else
			Console.WriteLine("This string does not contain \"HP\" in it's second and 3rd position.");
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine((string1.Substring(1, 2).Equals("HP") ? string1.Remove(1, 2) : string1));
		Console.WriteLine((string1.Substring(1, 2) == "HP" ? string1.Remove(1, 2) : string1));
		/**************************
		 *	W3resource's Solution
		 **************************/
		string str= "PHP Tutorial";
		Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));
	}
}
