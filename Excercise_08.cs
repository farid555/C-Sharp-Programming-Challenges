using System;
					
public class Exercise_08
{
	public static void Main()
	{
		
		/******************************************************************** 
		 *
		 *	8. Write a program that takes a number as input and
		 *	   print its multiplication table.
		 *
		 *
		 * 	By: Jesus Hilario Hernandez
		 * 	Last Updated: October 4th 2017
		 *
		 ********************************************************************/
		
		Console.WriteLine("Enter the number: 5");
		var number = Convert.ToInt32(Console.ReadLine());
		
		var ten = 10;
		for(var i = 0; i <= ten; i++)
		{
			Console.WriteLine("{1} * {2} = {3}", number, i, number * i);	
		}
	}
}
