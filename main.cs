// Created by: Timothy Manwell
// Created on: Nov 2022
//
// This program check calculates the cost of a cake order
using System;

class Program
{
    public static void Main(string[] args)
    {
      string text = null;
      var counter = 0;
      int integerA;
      int integerB;
      int integerBOV;
        
        Console.Write("Repeated addition using while loop.");
        Console.Write("\nEnter integer A: ");
        integerA = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nEnter integer B: ");
        integerBOV = integerB = Convert.ToInt32(Console.ReadLine());
      
        while (counter < integerA)
        {
        text = text + "\nYour number is: " + integerB;
        counter++;
        integerB = integerB + integerBOV;
        }

        Console.Write(text);
        Console.Write("\nDone");
    }
}