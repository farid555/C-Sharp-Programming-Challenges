/********************************************************************
*
*	13. Write a C# Sharp program to read temperature in centigrade and
*		display a suitable message according to temperature state below
*
*		Temp < 0 then Freezing weather
*		Temp 0-10 then Very Cold weather
*		Temp 10-20 then Cold weather
*		Temp 20-30 then Normal in Temp
*		Temp 30-40 then Its Hot
*		Temp >=40 then Its Very Hot
*		Test Data :
*		42
*		Expected Output :
*		Its very hot.
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: Nov. 30th 2017
*
*
********************************************************************/
using System;

public class Exercise_13
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("---- What's the weather. ---->");
		Console.Write("What is the current temperature?\n");
		var temperature = Convert.ToInt32(Console.ReadLine());

		if (temperature <= 0)
			Console.WriteLine("Freezing weather.");
		else if (temperature >= 0 && temperature <= 10)
			Console.WriteLine("Very Cold weather.");
		else if (temperature >= 10 && temperature <= 20)
			Console.WriteLine("Cold weather.");
		else if (temperature >= 20 && temperature <= 30)
			Console.WriteLine("Normal in Temp.");
		else if (temperature >= 30 && temperature <= 40)
			Console.WriteLine("It's Hot.");
		else if (temperature >= 40)
			Console.WriteLine("It's very Hot!");

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		if (temperature < 0)
 			Console.WriteLine("Freezing weather.");
 		else if (temperature < 10)
 			Console.WriteLine("Very Cold weather.");
 		else if (temperature < 20)
 			Console.WriteLine("Cold weather.");
 		else if (temperature < 30)
 			Console.WriteLine("Normal in Temp.");
 		else if (temperature < 40)
 			Console.WriteLine("It's Hot.");
 		else if (temperature > 40)
 			Console.WriteLine("It's very Hot!");

		/**************************
		 *	W3resource's Solution
		 **************************/
		int tmp;
		Console.Write("\n\n");
		Console.Write("Accept a temperature in centigrade and display a suitable message:\n");
		Console.Write("--------------------------------------------------------------------");
		Console.Write("\n\n");

		Console.Write("Input days temperature : ");
		tmp= Convert.ToInt32(Console.ReadLine());

	    if(tmp<0)
	              Console.Write("Freezing weather.\n");
	    else if(tmp<10)
			Console.Write("Very cold weather.\n");
		else if(tmp<20)
			Console.Write("Cold weather.\n");
		else if(tmp<30)
			Console.Write("Normal in temp.\n");
		else if(tmp<40)
			Console.Write("Its Hot.\n");
		else
			Console.Write("Its very hot.\n");

	}
}
