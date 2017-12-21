/********************************************************************
*
*	16. Write a C# Sharp program to check whether an alphabet
*		is a vowel or consonant.
*
*		Test Data :
*		k
*		Expected Output :
*		The alphabet is a consonant.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: Dec. 20th 2017
*
********************************************************************/
using System;

public class Exercise_16
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Enter a letter: ");
		var letter = Convert.ToChar(Console.ReadLine());

		if (letter >= 'A' && letter <= 'Z' || letter >= 'a' && letter <= 'z')
		{
			if (letter == 'a' || letter == 'A' || letter == 'i' || letter == 'I' || letter == 'o' || letter == 'O' || letter == 'e' || letter == 'E' || letter == 'u' || letter == 'U') {
				Console.WriteLine(letter + " is a vowel.");
			}
			else
			{
				Console.WriteLine(letter + " is a consonant.");
			}
		}
		else
		{
			Console.WriteLine(letter + " is not a letter.");
		}
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		if (letter >= 'A' && letter <= 'Z' || letter >= 'a' && letter <= 'z')
		{
			switch (letter)
			{
				case 'a':
				case 'A':
				case 'e':
				case 'E':
				case 'i':
				case 'I':
				case 'o':
				case 'O':
				case 'u':
				case 'U':
					Console.WriteLine(letter + " is a vowel.");
					break;
				default:
					Console.WriteLine(letter + " is a consonant.");
					break;
			}
		}
		else
		{
			Console.WriteLine(letter + " is not a letter.");
		}

		/**************************
		 *	W3resource's Solution
		 **************************/
		char ch;
		Console.Write("\n\n");
		Console.Write("check whether the input alphabet is a vowel or not:\n");
		Console.Write("-----------------------------------------------------");
		Console.Write("\n\n");

		Console.Write("Input an Alphabet (A-Z or a-z) : ");
		ch = Convert.ToChar(Console.ReadLine().ToLower());
		int i=ch;

		if(i>=48 && i<=57)
		{
		 	Console.Write("You entered a number, Please enter an alpahbet.");
		}
		else
		{
			switch (ch)
			{
		     	case 'a':
		        	Console.WriteLine("The Alphabet is vowel");
		        	break;
			    case 'i':
			        Console.WriteLine("The Alphabet is vowel");
			         break;
			    case 'o':
			        Console.WriteLine("The Alphabet is vowel");
			        break;
			    case 'u':
			        Console.WriteLine("The Alphabet is vowel");
			        break;
			    case 'e':
			        Console.WriteLine("The Alphabet is vowel");
			        break;
			    default:
			        Console.WriteLine("The Alphabet is not a vowel");
			        break;
		 	}
		}
	}
}
