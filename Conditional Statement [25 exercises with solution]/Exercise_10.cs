/********************************************************************
*
*	09. Write a C# Sharp program to find the eligibility of admission
*		for a professional course based on the following criteria:
*
*		Marks in Maths >=65
*		Marks in Phy >=55
*		Marks in Chem >=50
*		Total in all three subject >=180
*		or
*		Total in Math and Subjects >=140
*
*		Test Data :
*		Input the marks obtained in Physics :65
*		Input the marks obtained in Chemistry :51
*		Input the marks obtained in Mathematics :72
*		Expected Output :
*		The candidate is eligible for admission.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: November 21th, 2017
*
*
********************************************************************/
using System;

public class Exercise_09
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.Write("Input the marks obtained in Physics: ");
		var physicsGrade = Convert.ToInt32(Console.ReadLine());
		Console.Write("Input the marks obtained in Chemistry: ");
		var chemistryGrade = Convert.ToInt32(Console.ReadLine());
		Console.Write("Input the marks obtained in Mathematics: ");
		var mathematicsGrade = Convert.ToInt32(Console.ReadLine());

		if ((physicsGrade >= 55 && chemistryGrade >= 50 && mathematicsGrade >= 65) || (physicsGrade + chemistryGrade + mathematicsGrade >= 180))
			Console.WriteLine("The candidate is eligible for admission.");
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/

	}
}
