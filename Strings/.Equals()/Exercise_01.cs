/********************************************************************
*
*	38. Write a C# program to get a new string of two characters
*		from a given string. The first and second character of
* 		the given string must be "P" and "H", so PHP will be "PH".
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 14th 2017
*
*
********************************************************************/
using System;


public class Exercise_38
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		var string1 = "PHP";
		Console.WriteLine(string1.Substring(0, 2).Equals("PH") ? string1.Substring(0, 2) : string1);
		Console.WriteLine(string1.Substring(0, 2) == "PH" ? string1.Substring(0, 2): string1);

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		var result2 = "";
		if (string1.Length >= 1 && string1[0] == 'P')
			result2 += string1[0];
		if (string1.Length >= 2 && string1[1] == 'H')
			result2 += string1[1];
		Console.WriteLine(result2);

		/**************************
		 *	W3resource's Solution
		 **************************/
		string str1 = "PHP Tutorial";
		var result = "";

		if (str1.Length >= 1 && str1[0] == 'P')
			result += str1[0];
		if (str1.Length >= 2 && str1[1] == 'H')
			result += str1[1];
		Console.WriteLine(result);
	}
}
