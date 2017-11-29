/********************************************************************
*
*	12. Write a C# Sharp program to read roll no, name and marks of
*		three subjects and calculate the total, percentage and division.
*
*		Test Data :
*		Input the Roll Number of the student :784
*		Input the Name of the Student :James
*		Input the marks of Physics, Chemistry and Computer Application : 70 80 90
*		Expected Output :
*		Roll No : 784
*		Name of Student : James
*		Marks in Physics : 70
*		Marks in Chemistry : 80
*		Marks in Computer Application : 90
*		Total Marks = 240
*		Percentage = 80.00
*		Division = First
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: November 29th 2017
*
********************************************************************/
using System;
using System.Linq;

public class Exercise_12
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("<----- Student Information ----->");
		Console.Write("Input the Roll Number of the student: ");
		var studentRollNumber = Convert.ToString(Console.ReadLine());

		Console.Write("Input the student's Name: ");
		var studentName = Convert.ToString(Console.ReadLine());

		Console.Write("Input the students Grade in Physics: ");
		var physicsGrade = Convert.ToInt32(Console.ReadLine());
		Console.Write("Input the students Grade in Chemistry: ");
		var chemistryGrade = Convert.ToInt32(Console.ReadLine());
		Console.Write("Input the students Grade in Computer Application: ");
		var computerApplicationGrade = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("\nRoll No.: {0}", studentRollNumber);
		Console.WriteLine("Name of Student: {0}", studentName);
		Console.WriteLine("Marks in Physics: {0}", physicsGrade);
		Console.WriteLine("Marks in Chemistry: {0}", chemistryGrade);
		Console.WriteLine("Marks in Computer Application: {0}", computerApplicationGrade);

		int[] numbers = {physicsGrade, chemistryGrade, computerApplicationGrade};

		Console.WriteLine("Total Marks = {0}", numbers.Sum());
		Console.WriteLine("Percentage = {0}", Math.Round(numbers.Average(), 1));

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/

	}
}

// Resources used:
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays
// https://www.dotnetperls.com/sum
// https://www.dotnetperls.com/average
// https://msdn.microsoft.com/en-us/library/bb358946(v=vs.110).aspx
// https://stackoverflow.com/questions/12621640/rounding-a-variable-to-two-decimal-places-c-sharp
// https://msdn.microsoft.com/en-us/library/wyk4d9cy(v=vs.110).aspx
