using System;
using System.Numerics;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter N ( N should be greater or equal to zero) : ");
        int n = int.Parse(Console.ReadLine());

        BigInteger doubleNFact = 1; BigInteger firstDivFact = 1; BigInteger secondDivFact = 1;
        BigInteger result = 0;


        if (n >= 0)
        {
            for (int index = 0; index < n; index++)
            {
                int doubleN = 2 * n;
                int nPlusOne = n + 1;

                // 2N!
                do
                {
                    doubleNFact = doubleNFact * doubleN;
                    doubleN--;
                }
                while (doubleN > 0);

                //(N + 1)!
                do
                {
                    firstDivFact = firstDivFact * nPlusOne;
                    nPlusOne--;
                }
                while (nPlusOne > 0);

                // N!
                do
                {
                    secondDivFact = secondDivFact * n;
                    n--;
                }
                while (n > 0);

                result = doubleNFact / (firstDivFact * secondDivFact);
            }
            Console.WriteLine("And the result is : " + result);
        }
        else
            Console.WriteLine("Wrong input!");
    }
}
