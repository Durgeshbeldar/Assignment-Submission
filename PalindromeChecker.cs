// The Program will Accept a number and check whether it is Palindrome or not

using System;

class PalindromeChecker {
  public static void Main(string[] args) {
    int number;
    Console.WriteLine("Enter a Number :");
    number = int.Parse(Console.ReadLine());
    Console.WriteLine(IsPalindrome(number) ? "Palindrome" : "Not a Palindrome");
  }

  // IsPalindrome Function is used to check the number is Palindrome OR Not.
  public static bool IsPalindrome(int number) {
    const int deciDevider = 10;
    const int Zero = 0;
    // Negative numbers are not palindromes
    if (number < Zero) return false;
    int originalNumber = number;
    int reverseNumber = Zero;
    while (number > Zero) {
      // Extracting the digit from back
      int remainder = number % deciDevider;
      //Adding the Extracted digit to get reverse of originalNumber
      reverseNumber = reverseNumber * deciDevider + remainder;
      number /= deciDevider;
    }
    return (originalNumber == reverseNumber);
  }
}
