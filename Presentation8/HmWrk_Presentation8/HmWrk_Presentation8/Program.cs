using System;
using System.Collections.Generic;

namespace HmWrk_Presentation8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("which Shape you want to enter? (0) - Square : (1) - Circle");
                string whichShape = Console.ReadLine();
                Shape inputeShape;

                switch (whichShape)
                {
                    case "0":
                        {
                            Console.WriteLine("Pleas enter the square name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Pleas enter the square side: ");
                            double side = Convert.ToDouble(Console.ReadLine());
                            inputeShape = new Square(name, side);
                            shapes.Add(inputeShape);
                            Console.WriteLine($"Shape Name: {inputeShape.Name};  Area - {inputeShape.Area()}; Perimetr {inputeShape.Perimetr()}");
                            break;
                        }

                    case "1":
                        {
                            Console.WriteLine("Pleas enter the circle name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Pleas enter the circle radius: ");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            inputeShape = new Circle(name, radius);
                            shapes.Add(inputeShape);
                            Console.WriteLine($"Shape Name: {inputeShape.Name};  Area - {inputeShape.Area()}; Perimetr {inputeShape.Perimetr()}");
                            break;
                        }

                }
              //  Console.WriteLine($"Shape Name: {inputeShape.Name};  Area - {inputeShape.Area()}; Perimetr {inputeShape.Perimetr()}");
                Console.WriteLine();

            }
            Shape maxPerimetr = shapes[0];
            for(int i = 0; i < shapes.Count; i++)
            {
                if(shapes[i].Perimetr() > maxPerimetr.Perimetr())
                {
                    maxPerimetr = shapes[i];
                }
            }
            Console.WriteLine($"Largest perimetr is {maxPerimetr.Name} = {maxPerimetr.Perimetr()}");
            Console.WriteLine();

            shapes.Sort();
            foreach(Shape shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name};  Area: {shape.Area()}");
            }

        }

    }
}
