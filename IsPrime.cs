using System;
public class IsPrime{
    public static bool PrimeOrNot(int num){
        if(num <= 1)
        return false;
        for(int i = 2; i<num;i++){
            if(num%i==0){
                return false;
            }
        }
        return true;
    }
    public static void Main(string [] args){
        Console.WriteLine("Enter the Number : ");
        int number = int.Parse(Console.ReadLine());
        bool checkPrime = PrimeOrNot(number);
        Console.WriteLine(checkPrime ? "The Number is Prime" : "The Number is Not Prime");
    }
}