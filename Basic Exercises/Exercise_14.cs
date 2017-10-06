using System;
					
public class Exercise_14
{
	public static void Main()
	{
		
		/**********************************************************************
		 *
		 *	14. Write a program to convert from celsius degrees to Kelvin and
		 *		Fahreheit.
		 *
		 * 	By: Jesus Hilario Hernandez
		 * 	Last Updated: October 4th 2017
		 *
		 **********************************************************************/
		Console.Write("Enter the amount of celsius: ");
		var C = Convert.ToDouble(Console.ReadLine());
		var K = C + 273.15;
		var F = (C * (9/5.0) + 32);
		
		Console.WriteLine("Kelvin = {0}", K);
		Console.WriteLine("Fahrenheit = {0}", F);
		
	}
}
