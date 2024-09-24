// The Program Accept a number and print its factorial

using System;

class Factorials
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number :");
        // We Can use long Data Type As Well For Big Values
        int number = int.Parse(Console.ReadLine());
        int factorialNumber = GetFactorial(number);
        Console.WriteLine("The Factorial of Number {0} is {1}", number, factorialNumber);
    }

    static int GetFactorial(int number)
    {
        int factorial = 1;
        for (int i = number; i >= 1; i--)
        {
            factorial = factorial * i;
        }
        return factorial;
    }
}