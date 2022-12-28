// Created by: Allen Li
// Created on: Dec 2022
//
// This program displays, "Arithmetic Progression Calculator"

using System;

class Program
{
    public static void Main(string[] args)
    {
        int userNumber;
        int sum = 0;
        int add = 1;

        // This function accepts user input
        Console.WriteLine("The sum of N natural numbers:");
        Console.WriteLine(" ");
        Console.WriteLine("Enter an positive integer below:");
        Console.WriteLine(" ");

        Console.WriteLine("Number: ");
        userNumber = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(" ");

        for (int counter = 0; counter < userNumber; counter++)
        {
            sum = sum + add;
            add = add + 1;
        }
        Console.WriteLine(" ");
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("\nDone.");
    }
}