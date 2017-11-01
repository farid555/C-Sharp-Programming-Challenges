/********************************************************************
*
*	07. Write a C# Sharp program that takes distance and time as
*		input and displays the speed in
*		kilometers per hour and miles per hour.
*
*
*		Test Data:
*		Input distance(meters): 50000
*		Input timeSec(hour): 1
*		Input timeSec(minutes): 35
*		Input timeSec(seconds): 56
*		Expected Output:
*		Your speed in meters/sec is 8.686588
*		Your speed in km/h is 31.27172
*		Your speed in miles/h is 19.4355
*
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 30th 2017
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

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.Write("Input distance(meters): ");
 		var distInMeters = Convert.ToDouble(Console.ReadLine());
 		Console.Write("Input the hours: ");
 		var hours = Convert.ToDouble(Console.ReadLine());
 		Console.Write("Input the minutes: ");
 		var mins = Convert.ToDouble(Console.ReadLine());
 		Console.Write("Input the seconds: ");
 		var secs = Convert.ToDouble(Console.ReadLine());
 		Console.Write("Expected Output: ");

 		var timeInSecs = ((hours * 3600) + (mins * 60) + secs);
		var metersPerSecond = (distInMeters/timeInSecs);
		var kilometersPerHour = ((distInMeters/1000.0f)/(timeInSecs/3600.0f));
		var milesPerHour = (kilometersPerHour / 1.609f);

 		Console.Write("Your spead in meters/sec is {0}: ", metersPerSecond);
 		Console.Write("Your spead in km/h is {0}: ", kilometersPerHour);
 		Console.Write("Your spead in miles/h is {0}: ", milesPerHour);

		/**************************
		 *	W3resource's Solution
		 **************************/
		float distance;
     	float hour, min, sec;

     	float timeSec;
     	float mps;
     	float kph, mph;

     	Console.Write("Input distance(meters): ");
     	distance = Convert.ToSingle(Console.ReadLine());
	     Console.Write("Input timeSec(hour): ");
     	hour = Convert.ToSingle(Console.ReadLine());
     	Console.Write("Input timeSec(minutes): ");
     	min = Convert.ToSingle(Console.ReadLine());
     	Console.Write("Input timeSec(seconds): ");
     	sec = Convert.ToSingle(Console.ReadLine());

     	timeSec = (hour*3600) + (min*60) + sec;
     	mps = distance/timeSec;
     	kph = (distance/1000.0f)/(timeSec/3600.0f);
     	mph = kph / 1.609f;

     	Console.WriteLine("Your speed in meters/sec is {0}", mps);
     	Console.WriteLine("Your speed in km/h is {0}", kph);
     	Console.WriteLine("Your speed in miles/h is {0}", mph);
	}
}
