using System;

namespace HmWrk_Presentation2
{
    class Program
    {
        static void Main(string[] args)
        {/*
            //HmWrk2.a
            //read 3 float numbers and check: are they all belong to the range [-5,5].
            Console.WriteLine("Enter number");
            float number1 = float.Parse(Console.ReadLine());
            float number2 = float.Parse(Console.ReadLine());
            float number3 = float.Parse(Console.ReadLine());
            float[] arr = { number1, number2, number3 };

            for(int i =0; i < arr.Length; i++)
            {
                if (5 >= number1 & number2 >= -5)
                {
                    Console.WriteLine($"{arr[i]} belong to the range [-5,5]");
                }
            }
            //HmWork2.b
            //read 3 integers and write max and min of them.
            Console.WriteLine("Entre three number");
            int numberTaskB1 = Convert.ToInt32(Console.ReadLine());
            int numberTaskB2 = Convert.ToInt32(Console.ReadLine());
            int numberTaskB3 = Convert.ToInt32(Console.ReadLine());

            int max = numberTaskB1>numberTaskB2?numberTaskB1:numberTaskB2;
            max = max > numberTaskB3 ? max : numberTaskB3;
            Console.WriteLine($"Max - {max}");

            //HmWrk2.c
            //read number of HTTP Error (400, 401,402, ...)
            //and write the name of this error (Declare enum HTTPError)
            HTTPerror httpError;
            readHttpError(HTTPerror.first);
            readHttpError(HTTPerror.second);
            readHttpError(HTTPerror.third);
            readHttpError(HTTPerror.fourth);
            readHttpError(HTTPerror.fifth);


            void readHttpError(HTTPerror  httpError)
            {
                switch (httpError)
                {
                    case HTTPerror.first :
                        Console.WriteLine("Error #400.(with Convert.ToInt32) enum - " + Convert.ToInt32(HTTPerror.first));
                        break;

                    case HTTPerror.second:
                        Console.WriteLine("Error #401. (with Convert.ToInt32) enum - " + Convert.ToInt32(HTTPerror.second));
                        break;

                    case HTTPerror.third:
                        Console.WriteLine("Error #402.  enum - " + HTTPerror.third);
                        break;

                    case HTTPerror.fourth:
                        Console.WriteLine("Error #403.  enum - " + HTTPerror.fourth);
                        break;

                    case HTTPerror.fifth:
                        Console.WriteLine("Error #404.  enum - " + HTTPerror.fifth);
                        break;
                }
            }
            */

            //HmWrk2.d
            //declare struct Dog with fields Name, Mark, Age.
            //Declare variable myDog of Dog type and read values for it.
            //Output myDos into console. (Declare method ToString in struct)
            Dog myDog;
            myDog.name = "Boolka";
            myDog.mark = "Grove street";
            myDog.age = 13;
            myDog.info();

        }

        //HmWrk2.c enum
        enum HTTPerror 
        {
            first = 400,
            second = 401,
            third = 402,
            fourth = 403,
            fifth = 404
        }

        //HmWrk2.d struct
        struct Dog
        {
            public string name;
            public string mark;
            public int age;

            public void info()
            {
                Console.WriteLine($"Name - {name},\nMark - {mark},\nAge - {age}");
            }
        }

        
    }
}
