using System;

class CommonDivisor
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter your two numbers : ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        var ostatyk = 0;

    if ((a == 0) || (b == 0))
    {
        if (a == 0) Console.WriteLine("The Greatest Common Divider To Your Numbers Is : " + b);
        else Console.WriteLine("The Greatest Common Divider To Your Numbers Is : " + a);
    }
    else
    {
        if (a > b)
        {
            do
            {
                ostatyk = a % b;
                a = b;
                b = ostatyk;
            }
            while (b > 0);
            Console.WriteLine("The Greatest Common Divider To Your Numbers Is : " + a);
        }
        if (a < b)
        {
            do
            {
            ostatyk = b % a;
            b = a;
            a = ostatyk;
            }
            while (a > 0);
            Console.WriteLine("TThe Greatest Common Divider To Your Numbers Is : " + b);
        }
        if (a == b) 
            Console.WriteLine("You have entered equal numbers.");
    }
    }
}

