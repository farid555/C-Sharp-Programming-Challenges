/********************************************************************
*
*	42. Write a C# program to create a new string where the first
*	    4 characters will be in lower case. If the string is less
*		than 4 characters then make the whole string in upper case.
*
*	  Test Data:
*	  Input a string: w3r
*	  Sample Output
*	  W3R
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 15th 2017
*
********************************************************************/
using System;

public class Exercise_42
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
	    Console.Write("Input a string: ");
		var string1 = Convert.ToString(Console.ReadLine());
		//Console.WriteLine(string1.Length > 4 ? string1.ToLower() : string1);
		//if (string1.Length > 4)
		//	Console.WriteLine(string1.ToLower());
		//else
		//	Console.WriteLine(string1);
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		if (string1.Length < 4)
			Console.WriteLine(string1.ToUpper());
		else
		{
			Console.WriteLine(string1.Substring(0, 4).ToLower() + string1.Substring(4, string1.Length - 4));
			//Console.WriteLine(string1.Substring(4, string1.Length - 4));
		}
		/**************************
		 *	W3resource's Solution
		 **************************/
		Console.Write("Input a string: ");
        string str = Console.ReadLine();
        if (str.Length < 4)
        	Console.WriteLine(str.ToUpper());
        else
        	Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4, str.Length -4));
    }
}
