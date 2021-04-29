using System;

namespace Presentation1_HmWr
{
    class Program
    {   
        static void Main(string[] args)
        {
            //HomeWork1.a
            Console.WriteLine("Enter legth:");
            int lengthA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Perimetr = " + calculatePerimetr(lengthA));
            Console.WriteLine("Area = " + calculateArea(lengthA));

            int calculatePerimetr(int length)
            {
                int perimetr = length * 4;
                return perimetr;
            }

            int calculateArea(int legth)
            {
                int area = legth*legth;
                return area;
            }

            //HomeWork1.b
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you " + name + "?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is - {0} \nYour age is - {1} y.o", name, age);

            //HomeWork1.c
            Console.WriteLine("Enter R");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Legth = " + calculateLength(r));
            Console.WriteLine("Area = " + calculateAreaR(r));
            Console.WriteLine("Volume = " + calculateVolume(r));

            double calculateLength(double r)
            {
                double legth = 2 * Math.PI * r;
                return legth;
            }

            double calculateAreaR(double r)
            {
                double s = Math.PI * r * r;
                return s;
            }

            double calculateVolume(double r)
            {
                double v = (4/3*Math.PI) * r * r * r;
                return v;
            }
        }
    }
}
