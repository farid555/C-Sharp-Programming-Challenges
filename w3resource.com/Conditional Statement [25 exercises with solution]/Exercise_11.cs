/********************************************************************
*
*	11. Write a C# Sharp program to calculate root of Quadratic
*		Equation. ax2 + bx + c = 0
*
*		Test Data :
*		Input the value of a : 1
*		Input the value of b : 5
*		Input the value of c : 7
*		Expected Output :
*		Root are imaginary;
*		No Solution.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: November 25th 2017
*
*
********************************************************************/
using System;

public class Exercise_11
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.Write("Input the value of x: ");
		var x = Convert.ToInt32(Console.ReadLine());
		Console.Write("Input the value of y: ");
		var y = Convert.ToInt32(Console.ReadLine());
		Console.Write("Input the value of z: ");
		var z = Convert.ToInt32(Console.ReadLine());

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		double w, a1, a2;

		w = y * y - 4 * x * z;

 		if (w == 0)
 		{
 			Console.WriteLine("Both roots are equal.");
 			a1 = -y / (2.0 * x);
			a2 = a1;
			Console.WriteLine("First Root--Root1 = {0}", a1);
			Console.WriteLine("Second Root--Root2 = {0}", a2);
 		}
		else if (w > 0)
		{
			Console.WriteLine("Both roots are real and diff-2\n");

			a1 = (-y + Math.Sqrt(w)) / (2 * x);
			a2 = (-y - Math.Sqrt(w)) / (2 * x);

			Console.WriteLine("First Root--Root1 = {0}", a1);
			Console.WriteLine("Second Root--Root2 = {0}", a2);
		}
		else
			Console.WriteLine("The root is imaginary; No Solution");

		/**************************
		 *	W3resource's Solution
		 **************************/
		int a,b,c;

		double d, x1,x2;
		Console.Write("\n\n");
		Console.Write("Calculate root of Quadratic Equation :\n");
		Console.Write("----------------------------------------");
		Console.Write("\n\n");

		Console.Write("Input the value of a : ");
		a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Input the value of b : ");
		b = Convert.ToInt32(Console.ReadLine());
		Console.Write("Input the value of c : ");
		c = Convert.ToInt32(Console.ReadLine());

		d=b*b-4*a*c;

		if(d==0)
		{
			Console.Write("Both roots are equal.\n");
			x1=-b/(2.0*a);
			x2=x1;
			Console.Write("First  Root Root1= {0}\n",x1);
			Console.Write("Second Root Root2= {0}\n",x2);
		}
		else if(d>0)
		{
		   Console.Write("Both roots are real and diff-2\n");

		   x1=(-b+Math.Sqrt(d))/(2*a);
		   x2=(-b-Math.Sqrt(d))/(2*a);

		   Console.Write("First  Root Root1= {0}\n",x1);
		   Console.Write("Second Root root2= {0}\n",x2);
		}
		else
		    Console.Write("Root are imeainary;\nNo Solution. \n\n");
	}
}
