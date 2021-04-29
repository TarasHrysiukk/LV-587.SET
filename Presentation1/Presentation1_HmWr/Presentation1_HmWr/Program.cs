using System;

namespace Presentation1_HmWr
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int a = Convert.ToInt32(x);
            switch(a)
            {
                case 1:
                    Console.WriteLine("один без брейк");
                    break;
                case 2:
                    Console.WriteLine("два з брейк");
                    break;
                case 3:
                    Console.WriteLine("два з брейк");
                    break;
            }
        }
    }
}
