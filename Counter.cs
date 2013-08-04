using System;
using System.Numerics;

class Counter
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter N number : ");
        int n = int.Parse(Console.ReadLine());

        BigInteger nFact = 1;
        
        int zeroCount = 0;
        int n2 = n;
        do
        {
            nFact = nFact * n;
            n--;
        }
        while (n > 0);
        
        Console.WriteLine("N! = " + nFact);
        do
        {
            BigInteger counter1 = nFact / 10;
            nFact = counter1;
            zeroCount++;
        }
        while ( (nFact % 10) == 0 );
        Console.WriteLine("=============================================");
        Console.WriteLine("The count of zeroes at the end of N! is : " + zeroCount);
    }
}

