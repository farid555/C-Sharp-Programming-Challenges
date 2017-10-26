/********************************************************************
*
*	01. Write a C# Sharp program that takes three letters as 
*		input and display them in reverse order.
*
*		Test Data
*		Enter letter: b 
*		Enter letter: a
*		Enter letter: t
*		Expected Output :
*		t a b
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 25th 2017
*
*
********************************************************************/
using System;

public class Exercise_01
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.Write("Enter a letter: ");
		var char1 = Convert.ToChar(Console.ReadLine());
		Console.Write("Enter a letter: ");
		var char2 = Convert.ToChar(Console.ReadLine());
		Console.Write("Enter a letter: ");
		var char3 = Convert.ToChar(Console.ReadLine());
		Console.WriteLine(string.Join(" ", char3, char2, char1));
		
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine("{0} {1} {2}", char3, char2, char1);
		/**************************
		 *	W3resource's Solution
		 **************************/
		char letter,letter1,letter2;
  
    	Console.Write("Input letter: ");
    	letter = Convert.ToChar(Console.ReadLine());
 
    	Console.Write("Input letter: ");
	    letter1 = Convert.ToChar(Console.ReadLine());       
 
    	Console.Write("Input letter: ");
    	letter2 = Convert.ToChar(Console.ReadLine());
     
   	 	Console.WriteLine("{0} {1} {2}",letter2,letter1,letter);

	}
}
