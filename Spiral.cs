using System;

class Spiral
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter the length of your matrix : ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine();

        int[,] arr = new int[n, n];

        int value = 1;
        
        int top = 0;
        int right = n - 1;
        int bottom = n - 1;
        int left = 0;

        while (value <= n * n)
        {

            // Тук започваме да пълним най-горния ред с поска от ляво на дясно - т.е от 0,0 към 0,n-1
            for (int goLeft = top; goLeft <= right; goLeft++)
            {
                arr[top, goLeft] = value;
                value++;
            }
            top++;

            // Сега започваме да пълним най-дясната колона от горе на долу, т.е. от n-1,0 към n-1,n-1

            for (int goDown = top; goDown <= bottom; goDown++)
            {
                arr[goDown, right] = value;
                value++;
            }
            right--;

            // Сега започваме да пълним долния ред от дясно на ляво, т.е от n-1,n-1 към 0,n-1

            for (int goRight = right; goRight >= left; goRight--)
            {
                arr[bottom, goRight] = value;
                value++;
            }
            bottom--;

            //Сега започваме лява колона от долу на горе - от 0, н-1 към 0, н-2

            for (int goUp = bottom; goUp >= top; goUp--)
            {
                arr[goUp, left] = value;
                value++;
            }
            left++;
        }

        // Тук печатим на конзолата масива :

        for (int i = 0; i < n; i++)
        {
            Console.Write("|");
            for (int k = 0; k < n; k++)
            {
                Console.Write("{0,4}", arr[i,k]);
            }
            Console.Write("   |");
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}

