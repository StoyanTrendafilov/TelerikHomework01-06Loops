using System;

class FibonacciNumbersToN
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter the count of yor Fibonacci squence' numbers : ");
        int count = int.Parse(Console.ReadLine());
        int fibonacciOne = 0, fibonacciTwo = 1, sum = 1;
        int fibonacci = 0;
        for (int i = 0; i < count-2; i++)
        {
            fibonacci = fibonacciOne + fibonacciTwo;
            fibonacciOne = fibonacciTwo;
            fibonacciTwo = fibonacci;
            sum = sum + fibonacci;
        }
        Console.WriteLine("======================");
       Console.WriteLine("The sum of he first {0} fibonacci sequence members, is : {1}.", count, sum);
    }
}

