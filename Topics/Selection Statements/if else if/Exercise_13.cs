/********************************************************************
*
*	14. Write a C# Sharp program to check whether a triangle is Equilateral,
*		Isosceles or Scalene.
*		Test Data :
*		50 50 60
*		Expected Output :
*		This is an isosceles triangle.
*
*		An Equilateral triangle has 3 equal sides in length.
*		An Isosceles triangle has 2 equal sides in length.
*		A Scalene triangle has no equal sides.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: December 13th 2017
*
*
********************************************************************/
using System;

public class Exercise_14
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("What is the length of the 1st side of your triangle?");
		var triangleSide1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("What is the length of the 2nd side of the triangle?");
		var triangleSide2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("What is the length of the last side of the triangle?");
		var triangleSide3 = Convert.ToInt32(Console.ReadLine());

		// if side1 = side2 or side3
		// then --> either isosceles or Equilateral

		if (triangleSide1 == triangleSide2 || triangleSide1 == triangleSide3 || triangleSide2 == triangleSide3)
		{
			if (triangleSide1 == triangleSide3 && triangleSide3 == triangleSide2)
			{
				Console.WriteLine("This is an Equilateral triangle.");
			}
			else
			{
				Console.WriteLine("This is a Isosceles triangle.");
			}
		}
		else // if Scalene
		{
			Console.WriteLine("This is a Scalene triangle.");
		}
		/******************************************************
		 *	Jesus' Solution After checking W3resource'sresponse
		 ******************************************************/
		if (triangleSide1 == triangleSide2 && triangleSide2 == triangleSide3)
		{
			Console.WriteLine("This is an Equilateral Triangle.");
		}
		else if (triangleSide1 == triangleSide2 || triangleSide1 == triangleSide3 || triangleSide2 == triangleSide3)
		{
			Console.WriteLine("This is an isosceles Triangle.");
		}
		else
		{
			Console.WriteLine("This is a Scalene triangle.");
		}
		/**************************
		 *	W3resource's Solution
		 **************************/
		int sidea, sideb, sidec;
		Console.Write("\n\n");
		Console.Write("Check whether a triangle is Equilateral, Isosceles or Scalene:\n");
		Console.Write("-------------------------------------------------------");
		Console.Write("\n\n");

		Console.Write("Input side 1 of triangle: ");
		sidea= Convert.ToInt32(Console.ReadLine());

		Console.Write("Input side 2 of triangle: ");
		sideb= Convert.ToInt32(Console.ReadLine());

		Console.Write("Input side 3 of triangle: ");
		sidec= Convert.ToInt32(Console.ReadLine());


		if(sidea==sideb && sideb==sidec)
		{
		Console.Write("This is an equilateral triangle.\n");
		}
		else if(sidea==sideb || sidea==sidec || sideb==sidec)
		{
		Console.Write("This is an isosceles triangle.\n");
		}
		else
		{
		Console.Write("This is a scalene triangle.\n");
		}
	}
}
