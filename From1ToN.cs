using System;

class From1ToN
{
    static void Main(string[] args)
    {
        Console.Write("Please enter one integer : ");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter <= n)
        {
            Console.WriteLine(counter);
            counter++;
        }
    }
}

