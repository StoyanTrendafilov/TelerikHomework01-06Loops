using System;
using System.Numerics;

class TheProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Now, you will have to insert X and N, and we will calculate the sum of 1 + 1!/X^1 + 2!/X^2 ... N!/X^N");
        Console.Write("X = ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        BigInteger[] dividents = new BigInteger[n];

        BigInteger[] divisors = new BigInteger[n];

        BigInteger[] results = new BigInteger[n];

        BigInteger divident = 1, sum = 1, divisor = 1;

        for (int index = 0; index < dividents.Length ; index++)
        {
            int counter = index + 1;
            divident = 1;
                
            do
                {
                    divident = divident * counter;
                    counter --;
                }
                while (counter > 0);

            dividents[index] = divident;
            Console.WriteLine(dividents[index]);

            divisor = x * divisor;
            divisors[index] = divisor;
            Console.WriteLine(divisors[index]);

            results[index] = dividents[index] / divisors[index];
            Console.WriteLine(results[index]);
            Console.WriteLine("---------------------------");

            sum = sum + results[index];

        }
        Console.WriteLine("===================================");
        Console.WriteLine("And the final result of our euqation is : " + sum);

        //foreach (BigInteger result in results)
        //{
        //    sum = sum + result;
        //}
        
    }
}