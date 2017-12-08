/********************************************************************
*
*	44. Write a C# program to create a new string of every other
*		character (odd position) from the first position of a given
*		string.
*
*		Test Data:
*		Input a string : w3resource
*		Sample Output
*		wrsuc
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 19th 2017
*
*
********************************************************************/
using System;


public class Exercise_44
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.Write("Input a string: ");
		var string1 = Convert.ToString(Console.ReadLine());
		for (var i = 0; i < string1.Length; i = i + 2)
		{
			Console.Write(string1[i]);
		}

		Console.WriteLine();

		for (var i = 0; i < string1.Length; i++)
		{
			if (i % 2 == 0)
				Console.Write(string1[i]);
		}
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine();
		Console.WriteLine(!String.IsNullOrEmpty(string1));
		Console.WriteLine();

		/**************************
		 *	W3resource's Solution
		 **************************/
		Console.Write("Input a string : ");
    string str = Console.ReadLine();
    var result = string.Empty;
    for (var i = 0; i < str.Length; i++)
    {
        if (i % 2 == 0) result += str[i];
    }
    Console.WriteLine(result);
	}


}
