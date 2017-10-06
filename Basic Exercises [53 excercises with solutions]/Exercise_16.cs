/******************************************************************** 
*
*	15. Write a program remove specified a charcter from a non-empty
*		string using index of a character.
*
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 6th 2017
*
*
********************************************************************/
using System;

public class Exercise_16
{
	public static void Main()
	{
		var firstString = "w3resource";
		var secondString = "Python";
		var firstLetter = firstString.Remove(1, 9);
		var secondFirstLetter = secondString.Remove(1, 5);
		//Console.WriteLine(firstString.Remove(0, 1) + firstLetter);
		//Console.WriteLine(secondString.Remove(0, 1) + secondFirstLetter);

		Console.WriteLine(firstString.Substring(9) + firstString.Remove(0, 1).Remove(8) + firstLetter);
		Console.WriteLine(secondString.Substring(5) + secondString.Remove(0, 1).Remove(4) + secondFirstLetter);
		Console.WriteLine();
		
		/*************************
		 *
		 *	w3resource's Solution
		 *
		 *************************/
		
		Console.WriteLine(first_last("w3resource"));
		Console.WriteLine(first_last("Python"));
		Console.WriteLine(first_last("x"));
	}

	public static string first_last(string ustr)
	{
		return ustr.Length > 1 ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
	}
}

// RESOURCES USED: 
// 1. https://msdn.microsoft.com/en-us/library/czx8s9ts(v=vs.110).aspx
