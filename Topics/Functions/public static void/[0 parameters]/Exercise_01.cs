/********************************************************************
*
*	10. Write a C# Sharp program to find the eligibility of admission
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
* 	Last Updated: November 25th, 2017
*
*
********************************************************************/
using System;

public class Exercise_10
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

		// if ((physicsGrade >= 55 && chemistryGrade >= 50 && mathematicsGrade >= 65) || (physicsGrade + chemistryGrade + mathematicsGrade >= 180))
		// 	Console.WriteLine("The candidate is eligible for admission.");
		// else
		// 	Console.WriteLine("The candidate is NOT eligible for admission.");

		/*******************************************
		 *	Jesus' Solution After checking response
		 *******************************************/
		if (physicsGrade >= 55)
			if (chemistryGrade >= 50)
				if (mathematicsGrade >= 65)
					if (physicsGrade + chemistryGrade + mathematicsGrade >= 180 || physicsGrade + mathematicsGrade >= 140)
						Console.WriteLine("The candidate is eligible for admission.");
					else
						notEligible();
				else
					notEligible();
			else
				notEligible();
		else
			notEligible();

		/**************************
		 *	W3resource's Solution
		 **************************/
		int p,c,m;

		Console.Write("\n\n");
		Console.Write("Find eligibility for admission :\n");
		Console.Write("----------------------------------");
		Console.Write("\n\n");

		Console.Write("Eligibility Criteria :\n");
		Console.Write("Marks in Maths >=65\n");
		Console.Write("and Marks in Phy >=55\n");
		Console.Write("and Marks in Chem>=50\n");
		Console.Write("and Total in all three subject >=180\n");
		Console.Write("or Total in Maths and Physics >=140\n");
		Console.Write("-------------------------------------\n");

		Console.Write("Input the marks obtained in Physics :");
		p = Convert.ToInt32(Console.ReadLine());
		Console.Write("Input the marks obtained in Chemistry :");
		c = Convert.ToInt32(Console.ReadLine());
		Console.Write("Input the marks obtained in Mathematics :");
		m = Convert.ToInt32(Console.ReadLine());
		Console.Write("Total marks of Maths, Physics and Chemistry : {0}\n",m+p+c);
		Console.Write("Total marks of Maths and  Physics : {0}\n",m+p);

		if (m>=65)
			if(p>=55)
		    	if(c>=50)
		        	if((m+p+c)>=180||(m+p)>=140)
		           		Console.Write("The  candidate is eligible for admission.\n");
		        	else
		          		Console.Write("The candidate is not eligible.\n\n");
		      	else
		    		Console.Write("The candidate is not eligible.\n\n");
		  	else
		   		Console.Write("The candidate is not eligible.\n\n");
		else
			Console.Write("The candidate is not eligible.\n\n");

	}
	/******************************************************
	 *	(FUNCTIONS) Part of Jesus' Solution After checking
	 *	response.
	 ******************************************************/
	 public static void notEligible()
	 {
		 Console.WriteLine("The candidate is NOT eligible.");
	 }
}
