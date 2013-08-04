using System;
using System.Numerics;

class Productor
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Please, enter K and N. K should be GREATER than K, abd both of them shoul be \nGREATER than 1.");
        Console.Write(" K = ");
        int k = int.Parse(Console.ReadLine());
        Console.Write(" N = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("-------------");
        int divisor = k - n;
        
        BigInteger kfact = 1, nfact = 1, divfact = 1;
        BigInteger result = 1;

        bool passed = (k > n) && (n > 1);

        if (passed)
        {
            

            do
            {
                kfact = kfact * k;
                k--;
            }
            while (k > 0);
            Console.WriteLine("K! = " + kfact);

            do
            {
                nfact = nfact * n;
                n--;
            }
            while (n > 0);
            Console.WriteLine("N! = " + nfact);

            do
            {
                divfact = divfact * divisor;
                divisor--;
            }
            while (divisor > 0);
            Console.WriteLine("(K - N)! = " + divfact);

            result = (nfact * kfact) / divfact;
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("(K! * N!) / (K - N)! = " + result);
                
        }
        else
            Console.WriteLine("Wrong input, restart the program ;)");
    }
}

