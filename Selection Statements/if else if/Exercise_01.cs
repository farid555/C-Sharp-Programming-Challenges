/********************************************************************
*
*	04. Write a C# Sharp program that takes two numbers as input and 
*		perform an operation (+,-,*,x,/) on them and
*		displays the result of that operation.
*
*		Test Data
*		Input first number: 20
*		Input operation: - 
*	 	Input second number: 12
*		Expected Output :
*		20 - 12 = 8
*
* 	By: Jesus Hilario Hernandez
* 	Last Updated: October 25th 2017
*
*
********************************************************************/
using System;

public class Exercise_04
{
	public static void Main()
	{
		/************************
		 *	Jesus' Solution
		 ************************/
		Console.WriteLine("Input first #: ");
		var firstNum = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Input operation: ");
		var operation2 = Convert.ToChar(Console.ReadLine());
		Console.WriteLine("Input second #: ");
		var secondNum = Convert.ToInt32(Console.ReadLine());
		// Console.WriteLine("{0} {1} {2} = {3}", firstNum, operation, secondNum, (Convert.ToString(firstNum + operation + secondNum)));
		
		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		switch (Convert.ToString(operation2))
		{
			case "-": 
			Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, (firstNum - secondNum));
				break;
			case "+":
			Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, (firstNum + secondNum));
				break;
			case "x":
			case "X":
			case "*":
			Console.WriteLine("{0} x {1} = {2}", firstNum, secondNum, (firstNum * secondNum));
				break;
			case "/":
			Console.WriteLine("{0} / {1} = {2}", firstNum, secondNum, (firstNum / secondNum));
				break;
			case "%":
			Console.WriteLine("{0} % {1} = {2}", firstNum, secondNum, (firstNum % secondNum));
				break;
			default: 
				Console.WriteLine("SORRY! An operation must be entered.");
				break;
		}
		/**************************
		 *	W3resource's Solution
		 **************************/
		int x, y;
        char operation;
         
        Console.Write("Input first number: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input operation: ");
        operation = Convert.ToChar(Console.ReadLine());
        Console.Write("Input second number: ");
        y = Convert.ToInt32(Console.ReadLine());
         
        if (operation=='+')
            Console.WriteLine("{0} + {1} = {2}", x, y, x+y);
        else if (operation=='-')
            Console.WriteLine("{0} - {1} = {2}", x, y, x-y);
        else if ((operation=='x') || (operation=='*'))
            Console.WriteLine("{0} * {1} = {2}", x, y, x*y);
        else if (operation=='/')
            Console.WriteLine("{0} / {1} = {2}", x, y, x/y);
        else
            Console.WriteLine("Wrong Character");
	}
}
