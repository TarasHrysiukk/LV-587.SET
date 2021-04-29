using System;    //so as not to call in front of the console every time(System.Console.WriteLine())

namespace MyFirstProject  //such as some kind of container for the
                          //logical union of named entities
{
    class Program
    {
        static void Main(string[] args)  //entry poin
        {
            DateTime now = DateTime.Today; //create a variable of type date, assign it today's date
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();//assigns a variable to what is entered from the keyboard
            Console.WriteLine("Hello " + name + ", what year were you born?");
            try                             //catch an exception
            {
                //here I write the code where there can be an exception
                int birthYear = Convert.ToInt32(Console.ReadLine());   
                int currenYear = Convert.ToInt32(now.ToString("yyyy")); //yyy because yyyy-mm-dd
                int yourAge = currenYear - birthYear; //subtract
                Console.WriteLine("You are " + yourAge + " y.o.");

                if (yourAge > 18)   //if your age is over 18 years
                {
                    Console.WriteLine("You have already finished school");
                }
                else                //if your age is less than 18 years
                {
                    Console.WriteLine("You haven't finished school yet");
                }
            }
            catch (Exception e)   //if there is exception then
            {
                Console.WriteLine("Error:" + e.Message);
            }

            
        }
    }
}
