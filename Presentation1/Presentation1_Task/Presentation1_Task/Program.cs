using System;

namespace Presentation1_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1.1
            //Define integer variables a and b.Read values a and b from
            //Console and calculate: a+b, a-b, a*b, a/b. Output obtained results.
            int a;
            int b;
            Console.WriteLine("Enter value of a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of b (b<a):");
            b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine("Sum a + b = " + sum);

            int subtraction = a - b;
            Console.WriteLine("Subtraction a - b = " + subtraction);

            int multiply = a * b;
            Console.WriteLine("Multiply a * b = " + multiply);

            int divide = a / b;
            Console.WriteLine("Divide a / b = " + divide);

            //Task 1.2
            //Output question “How are you ?“. Define string variable answer.
            //Read the value answer and output: “You are(answer)". 
            Console.WriteLine("Hello, how are yuo?");
            string answer = Console.ReadLine();
            Console.WriteLine("You are " + answer);

            //Task 1.3
            //Read 3 variables of char type.
            //Write message: “You enter (first char), (second char), (3 char)”
            Console.WriteLine("Enter three Char");
            char firstChar = Convert.ToChar(Console.ReadLine());
            char secondChar = Convert.ToChar(Console.ReadLine());
            char thirdChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("You enter {0},{1},{2}", firstChar, secondChar, thirdChar);
            
            //Task 1.4  
            //Enter 2 integer numbers. Check if they are both positive – use bool expretion 
            Console.WriteLine("Enter two int");
            int firstIntNumber = Convert.ToInt32(Console.ReadLine());
            int secondIntNumber = Convert.ToInt32(Console.ReadLine());
           
            bool isBothPosotive = (firstIntNumber > 0 & secondIntNumber > 0); //the same as in if else
           Console.WriteLine(isBothPosotive);

            //can make this condition like this
            if (firstIntNumber > 0 & secondIntNumber > 0)
            {
                Console.WriteLine("they are both positive");
            }
            else
            {
                Console.WriteLine("one of them are negative");
            }

            
        }
    }
}
