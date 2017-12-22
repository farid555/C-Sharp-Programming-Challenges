/********************************************************************
*
*	19. Write a program in C# Sharp to accept a grade and declare
*		the equivalent description:
*
*		Grade		Description
*		E			Excellent
*		V			Very Good
*		G			Good
*		A			Average
*		F			Fail
*
*		Test Data :
*		Input the grade :a
*		Expected Output :
*		You have chosen : Average
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: Dec. 21st 2017
*
*
********************************************************************/
using System;

public class Exercise_19
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Input the grade: ");
		var grade = Convert.ToChar(Console.ReadLine().ToUpper());

		switch (grade)
		{
			case 'E':
				YouHaveChosen("Excellent.");
				break;
			case 'V':
				YouHaveChosen("Very Good.");
				break;
			case 'G':
				YouHaveChosen("Good.");
				break;
			case 'A':
				YouHaveChosen("Average.");
				break;
			case 'F':
				YouHaveChosen("Fail.");
				break;
			default:
				Console.WriteLine("Invalid input.");
				break;
		}
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/
		string notes;
		char grd;
			Console.Write("\n\n");
			Console.Write("Accept a grade and display equivalent description:\n");
			Console.Write("---------------------------------------------------");
			Console.Write("\n\n");


		Console.Write("Input the grade :");
		grd = Convert.ToChar(Console.ReadLine().ToUpper());

		switch(grd)
		{
			case 'E':
				notes= " Excellent";
				break;
			case 'V':
				notes= " Very Good";
				break;
			case 'G':
				notes= " Good ";
				break;
			case 'A':
				notes= " Average";
				break;
			case 'F':
				notes= " Fails";
				break;
			default :
				notes= "Invalid Grade Found.";
				break;
		}
		Console.Write("You have chosen  : {0}\n", notes);
	}

	/********************************
	 *	(Functions) Jesus' Solution	*
	 ********************************/
	public static void YouHaveChosen(string grade)
	{
		Console.WriteLine("You have chosen: {0}", grade);
	}
}
