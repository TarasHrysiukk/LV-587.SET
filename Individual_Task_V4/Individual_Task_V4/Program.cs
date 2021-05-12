using System;

namespace Individual_Task_V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        class Animal
        {
            DateTime birthYear;
            DateTime curentYear = DateTime.Today;
            string color;

            public DateTime BirthYear { get; set; }
            public string Color { get; set; }

            public Animal(DateTime birthYearAnimal, String colorAnimal)
            {
                BirthYear = birthYearAnimal;
                Color = colorAnimal;
            }
            string Voice()
            {
                return "I am an animal!";
            }

            public void Input()
            {
                Console.WriteLine("Enter color of your animal: ");
                string yourAnimalColor = Console.ReadLine();
                Console.WriteLine("Enter date of birth this animal");
                DateTime birthDateYouAnimal = Convert.ToDateTime(Console.ReadLine());
                BirthYear = birthDateYouAnimal;
               Color = yourAnimalColor;
            }

            public void Output()
            {
                Console.WriteLine($"{Color} animal was born in {BirthYear}");
            }

            public void GetAge()
            {
                //int age = 
            }
        }
    }
}
