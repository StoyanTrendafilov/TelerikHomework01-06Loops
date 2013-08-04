using System;
using System.Numerics;

class Divisibles
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter K and N. K should be smaller than N, abd both of them shoul be greater than 1.");
        Console.Write(" K = ");
        int k = int.Parse(Console.ReadLine());
        Console.Write(" N = ");
        int n = int.Parse(Console.ReadLine());

        BigInteger kfact = 1, nfact = 1;

        BigInteger result = 0, result1 = 0;

        bool passed = (n > k) && (k > 1);

        if (passed)
        {
            for (int i = 1; i <= k; i++) // показаният в презентацията начин за смятане на факториел е използван в следващата задача
            {                            // този тук си е мой ;)
                kfact = kfact * i;
            }
            for (int i = 1; i <= n; i++)
            {
                nfact = nfact * i;
            }
            result = nfact / kfact;
            //result1 = nfact % kfact; - Виж коментара по-долу ;)
            Console.WriteLine("Dividing N! to K!, we will get : " + result);
            // Console.WriteLine("The reminder is : " + result1); - беше ми любопитно дали има остатък, не, че го има в услвието, ама за проверка дали да не смена ингтиджъра с друг тип данни.
        }
        else
            Console.WriteLine("Wrong input, restart ghe program :)" );
    }
}

