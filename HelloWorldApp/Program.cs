using System;

class Program
{
    // Method to calculate the sum of two integers
    static int Sum(int a, int b)
    {
        return a + b;
    }
    static int Multiply(int a, int b)
    {
        return (a * b);
    }
    static void Main(string[] args)
    {
        // Call the Sum method with two integers and print the result
        int num1 = 5;
        int num2 = 7;
        int Add = Sum(num1, num2);
        int multiply=Multiply(num1, num2);

        Console.WriteLine($"The sum of {num1} and {num2} is: {Add}");
        Console.WriteLine($"The Multiplication of {num1} and {num2} is {multiply}");
        Console.ReadLine();
    }
}
