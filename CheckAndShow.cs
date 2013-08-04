using System;


class CheckAndShow
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter the number of numbers, you want to insert : ");
        int n = int.Parse(Console.ReadLine());
        int maximal = int.MinValue;
        int minimal = int.MaxValue;
        //int i = 0;
        bool passed = (n > 0);
        if (passed)
        {
            int[] number = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write(" Please enter a number : ");
                number[i] = int.Parse(Console.ReadLine());
                if (number[i] > maximal)
                {
                    maximal = number[i];

                }
                if (number[i] < minimal)
                {
                    minimal = number[i];
                }
            }
            Console.WriteLine("Min value : " + minimal);
            Console.WriteLine("Max value : " + maximal);
        }
        else
            Console.WriteLine("/nYour input is invalid, try again.");
    }
}

