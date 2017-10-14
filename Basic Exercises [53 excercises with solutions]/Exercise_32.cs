/********************************************************************
*
*	32. Write a program to create a new string of four copies, taking
*		last four characters from a given string. If the length of the
*		given string is < 4 return the original one.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 13th 2017
*
*
********************************************************************/
using System;


public class Exercise_32
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.Write("Input a string: ");
		var sentence = Convert.ToString(Console.ReadLine());
		var lastFourChars = sentence.Substring(sentence.Length -4);
		if (sentence.Length < 4)
		{
			Console.WriteLine(sentence);
		}
		else
		{
			for(var i = 0; i <= 3; i++)
			{
				Console.Write("{0}", lastFourChars);
			}
		}

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/
		string str;
           int l= 0;
           Console.Write("\nInput a string : ");
           str = Console.ReadLine();
           if (str.Length>4)
           {
              Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4)+ str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
           }
	}
}
