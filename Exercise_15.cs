using System;
					
public class Exercise_15
{
	public static void Main()
	{
		
		/******************************************************************** 
		 *
		 *	15. Write a program remove specified a charcter from a non-empty
		 *		string using index of a character.
		 *
		 *
		 * 	By: Jesus Hilario Hernandez
		 * 	Last Updated: October 5th 2017
		 *
		 ********************************************************************/
		Console.WriteLine(remove_char("w3resource", 1));
		Console.WriteLine(remove_char("w3resource", 9));
		Console.WriteLine(remove_char("w3resource", 0));
	}
	public static string remove_char(string str, int n)
	{
		return str.Remove(n,1);	
	}
}
