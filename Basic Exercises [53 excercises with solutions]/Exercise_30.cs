/********************************************************************
*
*	30. Write a program to convert a hexadecimal # to a decimal number.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 13th 2017
*
*
********************************************************************/
using System;

public class Exercise_30
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
		string hexVal2 = "4D0";
		Console.WriteLine("Hexadecimal #: " + hexVal2);
		int decValue2 = int.Parse(hexVal2, System.Globalization.NumberStyles.HexNumber);
		Console.WriteLine("Convert to-\nDecimal #: " + decValue2);
		/**************************
		 *	W3resource's Solution
		 **************************/
		string hexval = "4B0";
		Console.WriteLine("Hexadecimal number: " + hexval);
		int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
		Console.WriteLine("Convert to-");
		Console.WriteLine("Decimal #: " + decValue);
	}
}
