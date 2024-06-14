// See https://aka.ms/new-console-template for more information
﻿using System;
using System.Diagnostics.SymbolStore;

namespace EvaluateGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numGrades = GetnumGrades();
            double[] grades = Getgrades(numGrades);
			
            Console.WriteLine("END OF USER INPUT");
			Console.ReadKey();
            Console.WriteLine("PROCESSING GRADES....");
			Console.ReadKey();
            
			double average = Getaverage(grades);
			
            Console.WriteLine("The average grade is " + average);
            checkaverage(average);          
            
			Console.WriteLine("here are your grades:");
            Listofgrade(grades);         
        }

		
		static int GetnumGrades()
		{
           Console.Write("Enter how many grades you want to input: ");
            int numGrades= Convert.ToInt16(Console.ReadLine());
			return numGrades;			
        }		
		
		static double[] Getgrades(int listofgrades)
		     {
		         double[] grades = new double[listofgrades];
			    for(int counter = 0; counter<listofgrades; counter++)
			    {   
                Console.Write("Input grade: ");
                double grade = Convert.ToInt16(Console.ReadLine());
                if (grade > 0 && grade < 100)
                  {
                  grades[counter] = grade;
                  }
                else
				  {          
                  Console.WriteLine("Invalid Input.");
                  }
				}			
			  return grades;
			 }
			 
		static double Getaverage(double[] grades)
	        {
               double sum = 0;
               foreach (double grade in grades)
                {
                 sum += grade;
                }
               return sum / grades.Length;
            }
			
		
        static void checkaverage(double average)
		{	
		             if (average <= 50)
            {
                Console.WriteLine("FAILED");
            }
            else if (average > 50 && average <= 70)
            {
                Console.WriteLine("FAIR");
            }
            else if (average > 70 && average <= 80)
            {
                Console.WriteLine("GOOD");
            }
            else if (average > 80 && average <= 90)
            {
                Console.WriteLine("VERY GOOD");
            }
            else if (average > 90 && average <= 100)
            {
                Console.WriteLine("EXCELLENT");
            }
           }
		 
		 static void Listofgrade(double[] grades)
		 {
		  string message = string.Join("-",grades);
		  Console.WriteLine(message);
         }
    }
}



