/********************************************************************
*
*	17. Write a C# Sharp program to calculate profit and loss on a
*		transaction.
*
*		Test Data :
*		500 700
*		Expected Output :
*		You can book your profit amount : 200
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: Dec. 20th 2017
*
*
********************************************************************/
using System;

public class Exercise_17
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		var nums = new int[2];
		Console.Write("How much did you make last year? ");
		nums[0] = Convert.ToInt32(Console.ReadLine());
		Console.Write("How much did you make this year? ");
		nums[1] = Convert.ToInt32(Console.ReadLine());

		var difference = Math.Abs(nums[0] - nums[1]);

		if (nums[0] < nums[1])
		{
			Console.WriteLine("Your profit amount is {0}", difference);
		}
		else if (nums[0] > nums[1])
		{
			Console.WriteLine("Your loss amount is {0}", difference);
		}
		else
		{
			Console.WriteLine("Neither profit nor loss @ {0}", difference);
		}
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/
		int cprice,sprice, plamt;

		Console.Write("\n\n");
		Console.Write("Calculate profit and loss:\n");
		Console.Write("----------------------------");
		Console.Write("\n\n");

		Console.Write("Input Cost Price: ");
		cprice= Convert.ToInt32(Console.ReadLine());
		Console.Write("Input Selling Price: ");
		sprice= Convert.ToInt32(Console.ReadLine());

		if(sprice>cprice)
		{
			plamt = sprice-cprice;
			Console.Write("\nYou can booked your profit amount : {0}\n", plamt);
		}
		else if(cprice>sprice)
		{
			plamt = cprice-sprice;
			Console.Write("\nYou got a loss of amount : {0}\n", plamt);
		}
		else
		{
			Console.Write("\nYou are running in no profit no loss condition.\n");
		}
	}
}
// Resource used:
// https://answers.unity.com/questions/1289679/how-to-get-difference-between-two-values.html
// https://www.codeproject.com/Questions/253350/How-to-find-the-difference-of-two-numbers-in-array
// https://msdn.microsoft.com/en-us/library/dk4666yx(v=vs.110).aspx
// https://social.msdn.microsoft.com/Forums/en-US/8ff3fe2e-2912-49bd-bc73-2322baf675ee/difference-between-two-numbers?forum=csharplanguage
