using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11WtoriWariant
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int kind = 0 ; kind < 14; kind++)
            {
                switch (kind)
                {
                    case 0:
                        {
                            Console.Write("1.  Two of ");
                            for (int i = 0; i < 4; i++)
                            {
                                switch (i)
                                {
                                    case 0: Console.WriteLine("Spades"); break;
                                    case 1: Console.WriteLine("Hearts"); break;
                                    case 2: Console.WriteLine("Diamonds");break;
                                    case 3: Console.WriteLine("spades");break;
                                }
                            }
                        } break;
                    case 1:  Console.Write("2.  Three of "); break;
                    case 2:  Console.Write("3.  Four of "); break;
                    case 3:  Console.Write("4.  Five of "); break;
                    case 4:  Console.Write("5.  Six of "); break;
                    case 5:  Console.Write("6.  Seven of "); break;
                    case 6:  Console.Write("7.  Eight of "); break;
                    case 7:  Console.Write("8.  Nine of "); break;
                    case 8:  Console.Write("9.  Ten of "); break;
                    case 9:  Console.Write("10. Jack  of "); break;
                    case 10: Console.Write("11. Queen of "); break;
                    case 11: Console.Write("12. King of "); break;
                    case 12: Console.WriteLine("13. Ace of "); break;
                    case 13: Console.Write("========================"); break;
                }
             //  switch (kind)

                          
                }
            }
        }
    }

