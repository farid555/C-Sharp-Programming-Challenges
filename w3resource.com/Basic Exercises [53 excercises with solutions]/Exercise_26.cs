/********************************************************************
*
*	26. Write a program to compute the sum of the 1st 500 prime #s
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 12th 2017
*
*
********************************************************************/
using System;

public class Exercise_26
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		//for (var i = 1; i <= 500; i++)
		//{
		//	if (i % 2 != 0)
		//		Console.WriteLine("Prime: " + i);
		//	else
		//		Console.WriteLine("Not Prime: " + i);
		//}

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine("\nSum of the first 500 prime numbers: ");
		var total = 0; var counter = 0; var x = 2;

		for (var i = 1; i <= 500; i++)
		{
			switch (isPrime(i))
			{
				case true  :
      				Console.WriteLine("Prime " + i);
      				break;
   				case false  :
      				Console.WriteLine("Not Prime " + i);
      				break;

			}

		}

		while (counter < 500)
		{
			if (isPrime(x))
			{
				total += x;
				counter++;
			}
			x++;

		}
		Console.WriteLine(total.ToString());

		/**************************
		 *	W3resource's Solution
		 **************************/
		Console.WriteLine("\nSum of the first 500 prime numbers: ");
		long sum = 0;
		int ctr = 0;
		int n = 2;
		while (ctr < 500)
		{
			if (isPrime(n))
			{
				sum += n;
				ctr++;
			}

			n++;
		}

		Console.WriteLine(sum.ToString());
	}

	public static bool isPrime(int n)
	{
		int x = (int)Math.Floor(Math.Sqrt(n));
		if (n == 1)
			return false;
		if (n == 2)
			return true;
		for (int i = 2; i <= x; ++i)
		{
			if (n % i == 0)
				return false;
		}

		return true;
	}
}
