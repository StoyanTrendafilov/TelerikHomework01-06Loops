using System;

class Divisible
{
    static void Main(string[] args)
    {
        Console.Write("Please enter N : ");
        int n = int.Parse(Console.ReadLine());
        
        int counter = 0;

        int sum = 0;
        Console.Write("The sum of 1");
        while (counter < n)
        {
            if ((counter % 7 == 0) || (counter % 3 == 0))
            {
                counter++;
            }
            else
            {
                counter++;
                sum += counter;
                Console.Write(" + {0}" , counter);
            }

        }
        Console.WriteLine(" = {0}", (sum+1)); // Edinicata kompensira izostawaneto s 1 ot If uslowieto 
    }
}

