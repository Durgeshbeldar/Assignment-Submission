// Simple Implementation of Number Guessing Game in C#
using System;
using System.Collections.Generic;
namespace NumberGuessing
{
    // ===================== Main Method Class ==========================
    class NumberGuessingGame
    {   
        public static void Main(string[] args)
        { 
            PlayGameClass.PlayGame();
            Console.WriteLine("Do You Want to Play Again... Yes/No");
            string userChoice = Console.ReadLine();
            if (userChoice == "Yes" || userChoice == "yes")
                PlayGameClass.PlayGame();
            Console.WriteLine("Thank You For Playing the Game...!");
        }
    }
    
    public class PlayGameClass
    {
        const int MIN_NUMBER = 1;
        const int MAX_NUMBER = 100;
        const int MAX_ATTEMPTS = 7;
       
        public static void PlayGame()
        {
            Random random = new Random();
            int magicNumber = random.Next(MIN_NUMBER, MAX_NUMBER + 1);
            int remainingAttempts = MAX_ATTEMPTS;
            bool isGuessedCorrectly = false;
            List<int> geussedNumbers = new List<int>(7);

            // Instructions to user...
            Console.WriteLine("\n********  Welcome to the Number Guessing Game!  ********\n");
            Console.WriteLine("********  You need to guess a number (between 1 and 100).  ********\n");
            Console.WriteLine("You have 7 attempts to guess the correct number, Lets Start The Game...\n");

            while (remainingAttempts > 0 && !isGuessedCorrectly)
            {
                remainingAttempts--;
                Console.WriteLine($"\nEnter your guess (between {MIN_NUMBER} and {MAX_NUMBER} Inclusive): ");
                int userNumber = IsvalidNumber();
                isGuessedCorrectly = (userNumber == magicNumber);
                string guessResult = (isGuessedCorrectly) ? $"\nCongratulations! You have guessed the correct number!" +
                $"In {MAX_ATTEMPTS - remainingAttempts} Attempts" : (userNumber < magicNumber) ? "\nHint : The Number is Too Low, Try Again..."
                : "\nHint : The number is Too High, Please Try Again...";
                Console.WriteLine(guessResult);
                if (!isGuessedCorrectly)
                {
                    geussedNumbers.Add(userNumber);
                    Console.Write("\nThe Last Guessed Numbers is : ");
                    foreach (int number in geussedNumbers)
                    {
                        Console.Write(" " + number + " ");
                    }
                    Console.WriteLine($"\nAttempt Lefts : {remainingAttempts}");
                }
            }

            if (!isGuessedCorrectly)
                Console.WriteLine($"\nGame Over! The Correct Number was {magicNumber}");
            static int IsvalidNumber()
            {
                int userNumber = int.Parse(Console.ReadLine());
                if (userNumber >= 1 && userNumber <= 100)
                    return userNumber;
                Console.WriteLine($"Please Enter a Valid Number (Between {MIN_NUMBER} and {MAX_NUMBER})");
                return IsvalidNumber();
            }
        }
    }
}
