using System;
using System.Linq;

namespace Task_Presentation3
{
    class Program
    {
        private string nameOfDrink;
        static void Main(string[] args)
        {/*
            //Task3.1
            //Enter a and b are two integers. Calculate how many integers
            //in the range [a..b] are divided by 3 without remainder.
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int arrSize = a > b ? (a - b) + 1 : (b - a) ; 
            int[] arr = new int[arrSize];
            int counterInterInRange = 0;
            for (int i = 0; i < arrSize; i++)
            {
                arr[i] = a;
                a++;
         
                if (arr[i]%3 == 0)
                {
                    Console.WriteLine($"Divided by 3 without remainder - {arr[i]}");
                    counterInterInRange++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Size of arr  " + arrSize);
            Console.WriteLine($"{counterInterInRange} digits are divide by 3 without remainder");
            
            //Task3.2
            //Enter a character string. Print each second character
            Console.WriteLine("Enter some string : ");
            string someString = Console.ReadLine();
            char[] arrChar = someString.ToCharArray();
            for (int i = 0 ; i < arrChar.Length ; i++)
            {
                if (i%2 == 1)
                {
                    Console.WriteLine("every second char = " + arrChar[i]);
                }
                else
                {
                    continue;
                }
            }

            //Task3.3
            //Enter the name of the drink (coffee, tea, juice, water).
            //Print the name of the drink and its price.
            Console.WriteLine("Enter the name of the drink (coffe, tea, juice, water) : ");

            string nameOfDrink = Console.ReadLine();

            while (nameOfDrink != "coffee" & nameOfDrink != "tea" & nameOfDrink != "juice" & nameOfDrink != "water")
            {
                Console.WriteLine("Please enter correct name : ");
                nameOfDrink = Console.ReadLine();
                continue;
            }
            switch (nameOfDrink)
            {
                case "coffee":
                    Console.WriteLine($"name - {nameOfDrink}, price - 100$");
                    break;
                case "tea":
                    Console.WriteLine($"name - {nameOfDrink}, price - 10$");
                    break;

                case "juice":
                    Console.WriteLine($"name - {nameOfDrink}, price - 50$");
                    break;

                case "water":
                    Console.WriteLine($"name - {nameOfDrink}, price - 1$");
                    break;
            }
            
            //Task3.4
            //Enter a sequence of positive integers (to the first negative).
            //Calculate the arithmetic average of the entered numbers.

            //int[] arrNumb = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            int average; 
            int count = 0;
            int[] arrNumb = new int[1000];
            int sum = 0;
            int avarage;


            Console.WriteLine("Enter numbers: ");
            for ( int i = 0; i < arrNumb.Length; i++)
            {
                arrNumb[i] = int.Parse(Console.ReadLine());
                if (arrNumb[i] < 0)
                {
                    avarage = sum / count;
                    Console.WriteLine($"Arithmetic average of the entered numbers = {avarage}");
                    break;
                }
                else
                {
                    sum += arrNumb[i];
                    count++;
                }
            }

            */
            //Task3.5
            //Check whether the entered year is a leap.

            Console.WriteLine("Enter yera i'll be chek is a leap: ");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime todayDate = DateTime.Today;
            int currentYear = Convert.ToInt32(todayDate.ToString("yyyy"));
            int checkLeap = year - currentYear;
            if (checkLeap > 0)
            {
   
                Console.WriteLine("This year  is a leap into the future on " + (year-currentYear) + " years.");
              
            }
            else if (checkLeap < 0)
            {
                Console.WriteLine("This year is a leap back in time " + (year - currentYear) + " years.");
            }
            else if(checkLeap == 0)
            {
                Console.WriteLine("This year is not a leap");
            }

        }
    }
}
