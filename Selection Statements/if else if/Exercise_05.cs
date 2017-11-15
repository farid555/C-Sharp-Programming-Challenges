/********************************************************************
*
*	07. Write a C# Sharp program to accept the height of a person in
*		centimeter and categorize the person according to their height.
*
*		Test Data : 135
*		Expected Output:
*		The person is Darf.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: November 6th 2017
*
*
********************************************************************/
using System;

public class Exercise_07
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("How tall are you -- in centimeters?");
		var personsHeight = Convert.ToInt32(Console.ReadLine());

		//if (personsHeight <= 135)
		//	Console.WriteLine("According to your height, you are a dwarf.");
		//else
		//	Console.WriteLine("According to your height, you are not a dwarf.");

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		if (personsHeight < 150)
			Console.WriteLine("You are a Dwarf");
		else if ((personsHeight >= 150) && (personsHeight <= 165.0))
			Console.WriteLine("You are average height");
		else if ((personsHeight >= 165.0) && (personsHeight <= 195.0))
			Console.WriteLine("You are taller.");
		else
			Console.WriteLine("You are an abnormal height.");
		/**************************
		 *	W3resource's Solution
		 **************************/
		float PerHeight;
    	Console.Write("\n\n");
    	Console.Write("Accept the height of a person in centimeter and categorize them:\n");
    	Console.Write("----------------------------------------------------------------");
    	Console.Write("\n\n");

    	Console.Write("Input the height of the person (in centimetres):");
    	PerHeight = Convert.ToInt32(Console.ReadLine());

    	if (PerHeight < 150.0)
        	Console.Write("The person is Dwarf. \n\n");
    	else if ((PerHeight >= 150.0) && (PerHeight <= 165.0))
       		Console.Write("The person is  average heighted. \n\n");
    	else if ((PerHeight >= 165.0) && (PerHeight <= 195.0))
        	Console.Write("The person is taller. \n\n");
    	else
        	Console.Write("Abnormal height.\n\n");

	}
}
