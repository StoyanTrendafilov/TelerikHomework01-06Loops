using System;

class Drawing
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter N (N should be smaller than 20) : ");
        int n = int.Parse(Console.ReadLine());

        int k = 0;

        if (n < 20)
        {
            for (int column = 0; column < n; column++)
            {
                k = column;
                for (int row = 0; row < n; row++)
                {
                    k = k + 1;
                    Console.Write("|{0,2}", k);
                }
                Console.WriteLine();
            }
        }
        else Console.WriteLine("Wrong input, try again !");
    }
}

