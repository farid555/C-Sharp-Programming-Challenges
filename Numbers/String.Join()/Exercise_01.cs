/********************************************************************
*
*	39. Write a C# program to find the largest and lowest values from
*		three integer values.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 14th 2017
*
*
********************************************************************/
using System;

public class Exercise_39
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		var num1 = new int[3];
		Console.Write("Input 1st integer: ");
		num1[0] = Convert.ToInt32(Console.ReadLine());
		Console.Write("Input 2nd integer: ");
		num1[1] = Convert.ToInt32(Console.ReadLine());
		Console.Write("Input 3rd integer: ");
		num1[2] = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Your numbers: " + string.Join(", ", num1));
		var largestNum = num1[0];
		var smallestNumber = num1[0];

		for (var i = 0; i < num1.Length; i++)
		{
			if (num1[i] > largestNum)
				largestNum = num1[i];
			if (num1[i] < smallestNumber)
				smallestNumber = num1[i];
		}
		Console.WriteLine("\nLargest of the three integer is: {0}", largestNum);
		Console.WriteLine("Lowest of the three integer is: {0}", smallestNumber + "\n");

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine("\nLargest of the three: " + Math.Max(num1[0], Math.Max(num1[1], num1[2])));
		Console.WriteLine("Smallest of the three: " + Math.Min(num1[0], Math.Min(num1[1], num1[2])) + "\n");
		/**************************
		 *	W3resource's Solution
		 **************************/
		Console.WriteLine("\nInput first integer:");
		int x = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Input second integer:");
		int y = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Input third integer:");
		int z = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Largest of three: "+Math.Max(x, Math.Max(y, z)));
		Console.WriteLine("Lowest of three: "+Math.Min(x, Math.Min(y, z)));
	}
}
