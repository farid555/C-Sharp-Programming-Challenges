/********************************************************************
*
*	09. Write a C# Sharp program that takes a character as
*		input and check the input (lowercase) is a vowel,
*		a digit, or any other symbol.
*
*		Test Data:
*		Input a symbol: a
*		Expected Output:
*		It's a lowercase vowel.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 31st 2017
*
*
********************************************************************/
using System;

public class Exercise_09
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.Write("Input a symbol: ");
		var character = Convert.ToChar(Console.ReadLine());
		var asciiNumber = Convert.ToInt32(character);

		if (asciiNumber <= 65 && asciiNumber >= 90)
			Console.WriteLine("{0} is a letter.", character);
		else if (asciiNumber <= 57 && asciiNumber >= 48)
			Console.WriteLine("{0} is a number.", character);
		else
			Console.WriteLine("{0} is a symbol", character);

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine();

		/**************************
		 *	W3resource's Solution
		 **************************/
		char symbol;

	    Console.Write("Input a symbol: ");
	    symbol=Convert.ToChar(Console.ReadLine());

	    if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') || (symbol == 'o') || (symbol == 'u'))
	    	Console.WriteLine("It's a lowercase vowel.");
	    else if ((symbol >= '0') && (symbol <= '9'))
	        Console.WriteLine("It's a digit.");
	    else
	        Console.Write("It's another symbol.");
	}
}
