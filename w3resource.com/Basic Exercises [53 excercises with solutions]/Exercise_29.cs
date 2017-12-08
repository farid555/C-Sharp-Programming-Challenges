/********************************************************************
*
*	29. Write a program to find the size of a specified file in bytes
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 13th 2017
*
*
********************************************************************/
using System;
using System.Collections.Generic;
using System.IO;

public class Exercise_29
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		// Nada
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		FileInfo g = new FileInfo("/grand/flash/happyness/is/me.txt");
		Console.WriteLine("\nSize of a file: " + g.Length.ToString());

		/**************************
		 *	W3resource's Solution
		 **************************/
		FileInfo f = new FileInfo("/grand/flash/happy/is/me.txt");
		Console.WriteLine("\nSize of a file: " + f.Length.ToString());
	}
}
