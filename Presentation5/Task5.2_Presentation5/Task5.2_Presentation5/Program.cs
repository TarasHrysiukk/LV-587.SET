using System;
using System.Collections;
using System.Collections.Generic;

namespace Task5._2_Presentation5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Task5.2A
            List<IFlyable> flyable = new List<IFlyable>();
            flyable.Add(new Bird("Sokol", true));
            flyable.Add(new Bird("Kivi", false));
            flyable.Add(new Plane("Boing", false));
            flyable.Add(new Plane("Space-X", true));
            foreach (IFlyable item in flyable)
            {

                Console.WriteLine(item);
                item.Fly();
            }*/
             // Task5.2B
            ArrayList arr = new ArrayList();
            inputeArr();                                //inpute
            /*Console.WriteLine("ArrayList: \n");
            foreach(int el in arr)                      //outpute
            {
                Console.WriteLine(el);
            }
            positionOfElement(arr);                    //search for an element which == -10, print his index
            Console.WriteLine("After Position: ");
            foreach (int el in arr)                    //outpute                       
            {
                Console.WriteLine(el);
            }
            removeSomeElement(20);                     //search for an element which > 20, and remove them
            Console.WriteLine("After Removing Element > 20: ");
            foreach (int el in arr)                     //outpute 
            {
                Console.WriteLine(el);
            }*/

            insertElement();                        //insert some element
            Console.WriteLine("After insert some elements: ");
            foreach (int el in arr)                     //outpute 
            {
                Console.WriteLine(el);
            }

            arr.Sort();
            Console.WriteLine("After sorted: ");
            foreach (int el in arr)                     
            {
                Console.WriteLine(el);
            }



            void inputeArr()
            {
                Console.WriteLine("Enter your int number: ");
                for (int i = 0; i < 10; i++)
                {
                    int numb = int.Parse(Console.ReadLine());
                    arr.Add(numb);
                }
            }

            void positionOfElement(ArrayList arr1)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (arr[i].Equals(-10))
                    {
                        Console.WriteLine($"Position of elemet -10 in the colection = {i + 1}");
                    }
                }
            }

            void removeSomeElement(int greaterThan)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    int el = (int)arr[i];
                    if (el > greaterThan)
                    {
                        arr.RemoveAt(i);
                        i--;
                    }
                }
            }

            void insertElement()
            {
                Console.WriteLine("How many element you want insert?");
                int howManyElementWantInsert = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < howManyElementWantInsert ; i++)
                {
                    int count = 0;
                    Console.WriteLine($"Enter element № {count} : ");
                    int elementWhichwantInsert = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Which index: ");
                    int indexWhichwant = Convert.ToInt32(Console.ReadLine());
                    arr.Insert(indexWhichwant, elementWhichwantInsert);
                    count++;
                }
            }
        }
        
    }

    //Task5.2_A
    /*
    class Bird : IFlyable
    {
        string name;
        bool canFly;
        public void Fly()
        {
            Console.WriteLine("Method Fly from - Bird");
        }

        public Bird(string aName, bool aCanFly)
        {
            name = aName;
            canFly = aCanFly;
        }
        public override string ToString()
        {
            return "Name -" + name + " can Fly? - " + canFly;
        }
    }

    class Plane : IFlyable
    {
        string mark;
        bool highFly;
        public void Fly()
        {
            Console.WriteLine("Method Fly from - Plane");
        }

        public Plane(string aMark, bool aHighFly)
        {
            mark = aMark;
            highFly = aHighFly;
        }

        public override string ToString()
        {
            return "Mark -" + mark + " HighFly? - " + highFly;
        }
    }

    public interface IFlyable
    {
        public void Fly();
    }*/


    //Task5.3_B
    

}
