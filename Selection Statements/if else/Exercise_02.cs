/********************************************************************
*
*	01. Write a C# Sharp program to accept two integers and
*		check whether they are equal or not.
*
*		Test Data :
*		Input 1st number: 5
*		Input 2nd number: 5
*		Expected Output :
*		5 and 5 are equal
*
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
		Console.Write("Input 1st #: ");
		var num1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Input 2nd #: ");
		var num2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(num1 == num2 ? num1 + " and " + num2 + " are equal" : num1 + " and " + num2 + " are NOT equal");
		if (num1 == num2)
			Console.WriteLine("{0} and {1} are equal", num1, num2);
		else
			Console.WriteLine("{0} and {1} are NOT equal", num1, num2);

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/
		int int1,int2;
        Console.Write("\n\n");
        Console.Write("Check whether two integers are equal or not:\n");
        Console.Write("-------------------------------------------");
        Console.Write("\n\n");
        Console.Write("Input 1st number: ");
        int1= Convert.ToInt32(Console.ReadLine());

        Console.Write("Input 2nd number: ");
        int2= Convert.ToInt32(Console.ReadLine());

    	if (int1 == int2)
        	Console.WriteLine("{0} and {1} are equal.\n",int1,int2);
    	else
        	Console.WriteLine("{0} and {1} are not equal.\n",int1,int2);
	}
}
