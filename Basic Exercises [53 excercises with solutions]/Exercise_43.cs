/********************************************************************
*
*	43. Write a C# program to check if a given string starts with "w"
*	 	and immediately followed by two "ww".
*
*	Test Data:
*	Input a string : www
*	Sample Output
*	False
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 15th 2017
*
*
********************************************************************/
using System;


public class Exercise_43
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Input a string: ");
		var string1 = Convert.ToString(Console.ReadLine());
		Console.WriteLine(string1.Substring(0,1) == "w" && string1.Substring(1,2) == "ww");
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/

		/**************************
		 *	W3resource's Solution
		 **************************/
		Console.Write("Input a string : ");
        string str = Console.ReadLine();
        Console.WriteLine(test(str));
	}
	public static bool test(string str)
    {
        var ctr = 0;
        for (var i = 0; i > str.Length-1; i++)
        {
            if (str[i].Equals('w'))
				ctr++;
            if(str.Substring(i, 2).Equals("ww") && ctr > 2)
            	return true;
        }
        return false;
    }

}
