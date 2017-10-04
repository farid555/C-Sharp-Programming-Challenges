using System;
					
public class Program
{
	public static void Main()
	{
		/*
		 *	Examples from w3resource.com - 
		 *	C# Sharp Basic Exercises 
		 *	[53 exercises with soluction}
		 */
		// 1. Write a C# Sharp Program to print "Hello" and your name on a separate line.
		Console.WriteLine("Hello: ");
		Console.WriteLine("Jesus Hilario Hernandez");
		
		// 2. Write a C# Sharp program to print the sum of two numbers.
		Console.WriteLine(6 + 7);
		
		// 3. Write a C# Sharp program to print the result of dividing two numbers.
		Console.WriteLine(77/8.00);
		
		// 4. Write a program to print the result of the specified operations.
		Console.WriteLine(-1 + 4 * 6);
		Console.WriteLine((35 + 5) % 7);
		Console.WriteLine(14 + -4 * 6 / 11);
		Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
		
		// 5. Write a program to swap two numbers.
		Console.WriteLine("Input the First Number: 5");
		var firstNumber = Console.ReadLine();
		
		Console.WriteLine("Input the Second Number: 6");
		var secondNumber = Console.ReadLine();
		
		Console.WriteLine("After Swapping: ");
		Console.WriteLine("First Number: {0}", secondNumber);
		Console.WriteLine("Second Number: {0}", firstNumber);
		
		// Solution: Prefer my method.
		Console.Write("\nInput the First Number : ");
		var number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("\nInput the Second Number: ");
		var number2 = int.Parse(Console.ReadLine());
		var temp = number1;
		
		number1 = number2;
		number2 = temp;
		
		Console.Write("\nAfter Swapping : ");
		Console.Write("\nFirst Number : " + number1);
		Console.Write("\nSecond Number : " + number2);
		Console.WriteLine();
		
		// 6. Write a program to pring the output of multiplication of 3 numbers which will be entered by the user.
		Console.WriteLine("Input the first number to multiply: ");
		var firstNumberToMultiply = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Input the second number to multiply: ");
		var secondNumberToMultiply = Convert.ToInt32(Console.ReadLine());
		
		
		
		
	}
}
