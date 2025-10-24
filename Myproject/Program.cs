// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Task2
{
    static void Main()
    {
        //Declare and Initialize the 2D array
        //Row 0: Even numbers (2,4,6,8,10)
        //Row 1: Odd numbers (1,3,5,7,9)

        int[][] numberMatrix = new int[][]
        {
            new int[] { 2,4,6,8,10 },
            new int[] { 1,3,5,7,9 }
        };

        Console.WriteLine("\nThe number matrix has been initialized.\n");

        int digit1 = numberMatrix[1][3]; // = (7)
        int digit2 = numberMatrix[0][0]; // = (2)
        int digit3 = numberMatrix[1][4]; // = (9)

        string finalKey = $"{digit1}{digit2}{digit3}";

        Console.WriteLine("Extracted Digits:");
        Console.WriteLine($"Digit 1 (Row 1, Index 3):= {digit1}");
        Console.WriteLine($"Digit 2 (Row 0, Index 0):= {digit2}");
        Console.WriteLine($"Digit 3 (Row 1, Index 4):= {digit3}");
        Console.WriteLine($"\n(PASSWORD): {finalKey}\n");
    }
}