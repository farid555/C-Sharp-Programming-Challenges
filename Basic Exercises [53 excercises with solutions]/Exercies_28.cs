/********************************************************************
*
*	28. Write a program to reverse the words of a sentence
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 13th 2017
*
*
********************************************************************/
using System;
using System.Collections.Generic;

public class Exercise_28
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/


		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		string sentence2 = "What is it that you call when you do this to that?";
		Console.WriteLine("Original String: " + sentence2);

		string result2 = "";


		List <string> wordsList2 = new List <string> ();



		string[] words2 = sentence2.Split(new[] {
			" "
		}, StringSplitOptions.None);



		foreach(String s in words2)
		{
			Console.WriteLine(s);
		}



		for (int i = words2.Length - 1; i >= 0; i--)
		{
			result2 += words2[i] + " ";
		}

		wordsList2.Add(result2);
		foreach(String s in wordsList2)
		{
			Console.WriteLine("\nReverse String: " + s);
		}



		/**************************
		 *	W3resource's Solution
		 **************************/
		string sentence = "What is it that you call when you do this to that?";
		Console.WriteLine("Original String: " + sentence);

		string result = "";
		List <string> wordsList = new List <string> ();

		string[] words = sentence.Split(new[] {
			" "
		}, StringSplitOptions.None);

		for (int i = words.Length - 1; i >= 0; i--)
		{
			result += words[i] + " ";
		}

		wordsList.Add(result);
		foreach(String s in wordsList)
		{
			Console.WriteLine("\nReverse String: " + s);
		}
	}
}
