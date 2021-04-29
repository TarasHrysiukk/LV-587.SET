using System;

namespace Task_Presentation2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task2.1
            //Enter two integers numbers and check if they can represent the day and month.
            //Print true or false.
            Console.WriteLine("Enter two number: ");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            bool canRepresentDayAndMonth = (day <= 31 & month <= 12 & day>0 & month>0);
            Console.WriteLine($"can represent the day and month? - {canRepresentDayAndMonth}");
            
            //Task2.2
            //Enter double  number  and get the first 2 digits after the point of this
            //number and output the sum of these numbers. For example: 3.456 -> 4+5=9
            Console.WriteLine("Enter double number");
            double number = Convert.ToDouble(Console.ReadLine());
            double remainder = Math.Floor(number); //Rounded to the bottom so as not to change the value of the integer
            double afterPoint = Math.Round(number - remainder,3);//3 numbers after point
            Console.WriteLine("Befor point " + remainder);
            Console.WriteLine("After point " + afterPoint);
            int afterPointDigits = Convert.ToInt32(Math.Floor(afterPoint * 100));//multiply and cut digit after point
            Console.WriteLine("After poin after rounded " + afterPointDigits);

            int getSum(int n){
                int sumOfDigits = 0;
                while (n != 0)
                {
                    sumOfDigits = sumOfDigits + n % 10;
                    n = n / 10;
                }
                return sumOfDigits;
            }
            Console.WriteLine("Sum of first 2 didgits after the point = " + getSum(afterPointDigits));
            

            //Task2.3
            //Enter integer number h, representing the time of day (hour).
            //Depending on the time of day, print greetings (
            //"Good morning!", "Good afternoon!", "Good evening!", "Good night!")
            Console.WriteLine("Enter current hour");
            int hour = Convert.ToInt32(Console.ReadLine());
           if(6 <= hour & hour < 12) {
                Console.WriteLine("Good Morning");
            }
           else if(12 < hour & hour < 18)
            {
                Console.WriteLine("Good Afternoon");
            }
           else if (18 < hour & hour < 21)
            {
                Console.WriteLine("Good evening");
            }
            else if (18 < hour & hour < 24 ^ hour< 6 )
            {
                Console.WriteLine("Good Night");
            }
            //Task2.4
            //Identify enum TestCaseStatus (Pass, Fail, Blocked, WP, Unexecuted).
            //Assign status “Pass” for the variable  test1Status and print the
            //value of the variable console.
            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine($"test1Status - {test1Status}");
            


            //Task2.5
            //Determine RGB structure that represents the color with fields red, green, blue (type byte).
            //Identify two variables of this type and enter their fields for white and black colors
            RGB black;
            black.red = 0;
            black.green = 0;
            black.blue = 0;
            black.info("black");

            black.blue = 255;
            black.green = 255;
            black.red = 255;
            black.info("white");

        }
        //Task2.4
        //Identify enum TestCaseStatus (Pass, Fail, Blocked, WP, Unexecuted).
        //Assign status “Pass” for the variable  test1Status and print the
        //value of the variable console.
        enum TestCaseStatus
        {
            Pass,
            Fail,
            blocked,
            WP,
            Unexecuted
        }


        //Task2.5
        //Determine RGB structure that represents the color with fields red, green, blue (type byte).
        //Identify two variables of this type and enter their fields for white and black colors
        struct RGB
        {
            public byte red;
            public byte green;
            public byte blue;
           public void info(String color)
            {
                Console.WriteLine($"{color} - {red}, {green}, {blue}");
            }
        }
    }
}
