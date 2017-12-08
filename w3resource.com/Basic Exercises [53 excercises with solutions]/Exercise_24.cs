/********************************************************************
*
*	24. Write a program to find the longest word in a string.
*
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 11th 2017
*
*
********************************************************************/
using System;

public class Exercise_24
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		//Nada

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine("Write a sentence: ");
		var line_2 = Convert.ToString(Console.ReadLine());

		string[] words_2 = line_2.Split(new[]{" "}, StringSplitOptions.None);
		foreach(String arrayOfWords in words_2)
		{
			Console.Write(arrayOfWords + " ");
		}

		var word_2 = "";
		var ctr_2 = 0;
		foreach (String wordLength in words_2)
		{
			if (wordLength.Length > ctr_2)
			{
				word_2 = wordLength;
				ctr_2 = wordLength.Length;
			}
		}
		Console.WriteLine("\n" + word_2);

		/**************************
		 *	W3resource's Solution
		 **************************/
		string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
		string[] words = line.Split(new[]{" "}, StringSplitOptions.None);
		string word = "";
		int ctr = 0;
		foreach (String s in words)
		{
			if (s.Length > ctr)
			{
				word = s;
				ctr = s.Length;
			}
		}

		Console.WriteLine(word);
	}
}
