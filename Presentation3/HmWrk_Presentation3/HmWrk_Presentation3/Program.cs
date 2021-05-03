using System;

namespace HmWrk_Presentation3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //HmWrk3.a
            //Read the text as a string value and calculate the
            //counts of characters 'a', 'o', 'i', 'e' in this text.
            int countA = 0;
            int countO = 0;
            int countE = 0;
            int countI = 0;

            Index indexString = 2;
            Console.WriteLine("Enter your  string");
            string yourString = Console.ReadLine().ToLower();
            char[] arrYourString = yourString.ToCharArray();
            for (int i = 0 ; i < arrYourString.Length; i++)
            {
                switch (arrYourString[i])
                {
                    case 'a':
                        countA++;
                        break;

                    case 'o':
                        countO++;
                        break;

                    case 'e':
                        countE++;
                        break;

                    case 'i':
                        countI++;
                        break;
                }
            }
            Console.WriteLine($"Your string contaoin: \n{countA} - A \n{countO} - O \n{countE} - E \n{countI} - I");
            

            //HmWrk3.b
            //Ask user to enter the number of month.
            //Read the value and write the amount of days in this month.

            DateTime currentYear = DateTime.Today;
            Console.WriteLine("Enter the number of month: ");
            int numberOfMonth = Convert.ToInt32(Console.ReadLine());

            switch (numberOfMonth)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("This month have 31 days");
                    break;
                
                case 2:
                    int yearNow = Convert.ToInt32(currentYear.ToString("yyyy"));
                    if (DateTime.IsLeapYear(yearNow))
                    {
                        Console.WriteLine("it is a leap year, this month have 29 days");
                    }
                    else
                    {
                        Console.WriteLine("This month have 28 days");
                    }
                    break;
                
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("This month have 30 days");
                    break;
            }
            
            //HmWrk3.c
            //Enter 10 integer numbers. Calculate the sum of first 5 elements
            //if they are positive or product of last 5 element in  the other case.

            int[] arrNumb = new int[10];
            int sum = 0;
            int multiply = 1;
            bool isPositive = true;

            Console.WriteLine("Enter 10 integer numbers: ");
            for(int i = 0 ; i < arrNumb.Length; i++)
            {
                
                arrNumb[i] = Convert.ToInt32(Console.ReadLine());
            
                if(i <= 5)
                { 
                    if (arrNumb[i] >= 0)
                    {
                        sum += arrNumb[i];    
                    }

                    else
                    {
                        isPositive = false;
                    }
                } 
                else if (i>5 )
                {
                    multiply = multiply * arrNumb[i];
                }
            }

            if (isPositive)
            {
                Console.WriteLine($"First 5 element are positive, sum of them = {sum}");
            }
            else
            {
                Console.WriteLine($"the product of the last 5 elements = {multiply},\n because the first 5 contain negative numbers.");
            }
        }
    }
}
