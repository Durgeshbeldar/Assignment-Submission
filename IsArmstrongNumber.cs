//Program that accept a number and check whether it is an Armstrong number or not.
using System;

public class IsArmStrongNumber{
    // Function for calculating the power, We can use inbuilt Function as well.
    public static int Power(int baseNum, int pow){
            int powerNum = 1;
            for(int i = 1; i<=pow;i++){
                powerNum = powerNum*baseNum;
            }
            return powerNum;
    }
    //Function to check the number is Armstrong OR Not.
    public static bool IsArmStrong(int num){
        if(num<1)
        return false;
        int deci = 10;
        int temp = num;
        // ToString().Length is used to find out number of digits in the given number
        int count = num.ToString().Length;
        int sum = 0;
        int digit;
        temp = num;
        while(temp > 0){
           digit = temp%deci;
           sum = sum + Power(digit,count);
           temp = temp/deci;
        }
        return (num == sum);
    }
   public static void Main(string [] args){
    Console.WriteLine("Enter a Number : ");
    int number = int.Parse(Console.ReadLine());
    bool checkArmStrong = IsArmStrong(number);
    Console.WriteLine(checkArmStrong ? "The Number is Armstrong" : "The Number is Not Armstrong");
   }
}