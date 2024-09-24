// The Program is Accept a number and print its reverse..
using System;

class NumberReversal
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int reversedNumber = ReverseNumber(number);
        Console.WriteLine("The reverse of {0} is {1}", number, reversedNumber);
    }

    static int ReverseNumber(int number)
    {
        int Deci = 10;
        int reverseNumber = 0;
        while (number > 0)
        {
            // Get the last digit
            int remainder = number % Deci;
            // Append it to reverse
            reverseNumber = reverseNumber * Deci + remainder; 
            // Removing the last digit from the original number
            number /= Deci; 
        }
        return reverseNumber;
    }
}
