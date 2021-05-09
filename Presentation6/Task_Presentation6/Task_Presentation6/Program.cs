using System;

namespace Task_Presentation6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int start = 10;
            int end = 100;
            try
            {
               // string x = Console.ReadLine();
               // string y = Console.ReadLine();
                Console.WriteLine("enter you number: ");

               // Div(); //Task
                ReadNumber();

               /* void Div()
                {
                    if ((x.Contains(".") ^ x.Contains(",")) ^ (y.Contains(".") ^ y.Contains(",")))
                    {
                        throw new Exception("Variable Must be int ");
                    }
                    {
                        double resulte = Convert.ToInt32(x) / Convert.ToInt32(y);
                        Console.WriteLine(resulte);
                    }
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine("You type wrong type of data -" + ex.Message);
            }


            
            void ReadNumber()
            {
                
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"Enter your number: "); 
                    int numbAsker = Convert.ToInt32(Console.ReadLine());
                    if (numbAsker > start & numbAsker < end)
                    {
                        Console.WriteLine($"You number is {numbAsker}");
                    }
                    else
                    {
                        throw new Exception("Wrong number");
                    }
                }
            }
        }
    }
}

