﻿using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the first number
        Console.WriteLine("Enter the first number:");
        int num1;
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

        // Prompt the user to enter the second number
        Console.WriteLine("Enter the second number:");
        int num2;
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

        // Declare result variables
        bool divisionByZero = false;
        int sum = num1 + num2;
        int difference = num1 - num2;
        int product = num1 * num2;
        double quotient = 0;

        // Handle division
        if (num2 == 0)
        {
            divisionByZero = true;
        }
        else
        {
            quotient = (double)num1 / num2;
        }

        // Print the results
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The difference is: " + difference);
        Console.WriteLine("The product is: " + product);
        if (!divisionByZero)
        {
            Console.WriteLine("The quotient is: " + Convert.ToInt32(quotient));
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
    }
}
