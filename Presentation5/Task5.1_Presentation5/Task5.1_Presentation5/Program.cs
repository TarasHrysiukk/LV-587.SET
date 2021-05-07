using System;
using System.Collections.Generic;

namespace Task5._1_Presentation5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFlyable> flyable = new List<IFlyable>();
            flyable.Add(new Bird("Sokol", true));
            flyable.Add(new Bird("Kivi", false));
            flyable.Add(new Plane("Boing", false));
            flyable.Add(new Plane("Space-X", true));
            foreach (IFlyable item in flyable)
            {

                Console.WriteLine(item);
                item.Fly();
            }
        }
    }

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
    }
}
