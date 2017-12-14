/********************************************************************
*
*	15. Write a C# Sharp program to check whether a triangle can be formed by the *		given value for the angles.
*
*		Test Data :
*		40 55 65 != 180
*		Expected Output :
*		The triangle is not valid.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: Dec. 14th 2017
*
*
********************************************************************/
using System;
using System.Linq;

public class Exercise_15
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("What is the angles for you supposed triangle? ");
		var angle1 = Convert.ToInt32(Console.ReadLine());
		var angle2 = Convert.ToInt32(Console.ReadLine());
		var angle3 = Convert.ToInt32(Console.ReadLine());

		var angles = new int[3];
		angles[0] = angle1;
		angles[1] = angle2;
		angles[2] = angle3;

		if (angle1 + angle2 + angle3 == 180)
		{
			Console.WriteLine("Your triangle is valid.");
		}
		else
		{
			Console.WriteLine("Not a triangle.");
		}

		// Lo Mismo Que
		if (angles.Sum() == 180)
		{
			Console.WriteLine("Your triangle is valid.");
		}
		else
		{
			Console.WriteLine("Not a triangle.");
		}
		
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/
		int anga, angb, angc, sum; //are three angles of a triangle
		Console.Write("\n\n");
		Console.Write("Check whether a triangle can be formed by given value:\n");
		Console.Write("--------------------------------------------------------");
		Console.Write("\n\n");

		Console.Write("Input angle1 of triangle: ");
		anga= Convert.ToInt32(Console.ReadLine());

		Console.Write("Input angle 2 of triangle: ");
		angb= Convert.ToInt32(Console.ReadLine());

		Console.Write("Input angle 3 of triangle: ");
		angc= Convert.ToInt32(Console.ReadLine());

		/* Calculate the sum of all angles of triangle */
		sum = anga + angb + angc;

		/* Check whether sum=180 then its a valid triangle otherwise not */
		if(sum == 180)
		{
		 Console.Write("The triangle is valid.\n");
		}
		else
		{
		 Console.Write("The triangle is not valid.\n");
		}
	}
}
