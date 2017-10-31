/********************************************************************
*
*	02. Write a C# Sharp program that takes a number and a width also 
*		a number, as input and then displays a triangle of that width, 
*		using that number.
*
*		Test Data
*		Enter a number: 6 
*		Enter the desired width: 6 
*		Expected Output :
*
*		666666                                                      
*		66666                                                           
*		6666                                                                  
*		666                                                        
*		66                                                                  
*		6 
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 25th 2017
*
*
********************************************************************/
using System;

public class Exercise_02
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.Write("Enter a #: ");
		var userNum = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter a width: ");
		var userWidth = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Expected Output: \n");
		for (var i = userWidth; i > 0; i--)
		{
			for (var j = 0; j < i; j++)
			{		
				Console.Write(userNum);
			}
			Console.WriteLine();
		}
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		Console.WriteLine();
		/**************************
		 *	W3resource's Solution
		 **************************/
		Console.Write("Input a number: ");
   		int num = Convert.ToInt32( Console.ReadLine() );
 
	   	Console.Write("Input the desired width: ");
   		int width = Convert.ToInt32( Console.ReadLine() );
 
	   	int height = width;   
   		for (int row=0; row < height; row++)
   		{
    		for (int column=0; column < width; column++)
   			{
   				Console.Write( num );
  			}
   		Console.WriteLine();
   		width--;
  		}
	}
}
