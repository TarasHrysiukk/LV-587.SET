using System;

/// <summary>
/* Variant 4
Define a class Animal which contains:
-    Fields BirthYear, Color
-    Method Voice() that returns a string like “I am an animal!!!”
-    Constructor with parameters
-    Input() and output() methods for input / output from / to console
-    Getters and setters
-    Method GetAge() calculating the animals’s age in full years
-    Overridden ToString() method calling the Voice() method
Define a descendant class Bird that has:
-    Additional fields Species, EggsCount 
-    Constructor with parameters 
-    Additional getters and setters
-    Overridden Voice() method
-    Overridden input() and output() methods
Create a collection of animals and add some different animals and birds to it.              
-	 Output the data about birds elder than 3 years
-	 Sort the data by Species
-	 Output the collection to a file
-	 Implement exception handling
-	 Serialize the collection to XML file
-	 Deserialize it back
-	 Write unit tests
*/
/// </summary>
namespace Individual_Task_V4
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Enter the color of your animal: ");
            
           // string animalColor = Console.ReadLine();
            Animal animal = new Animal();
            animal.Input();
            animal.Output();
        }
    }

    public class Animal
    {
        int birthYear;
        //DateTime curentYear = DateTime.Now.Year;
        string color;

        public int BirthYear { get; set; }
        public string Color { get; set; }

        public Animal()
        {
           
        }
        public Animal(int birthYearAnimal, String colorAnimal)
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
            int birthDateYourAnimal = Convert.ToInt32(Console.ReadLine());
            BirthYear = birthDateYourAnimal;
            Color = yourAnimalColor;
        }

        public int GetAge(int birthYear)
        {
            return DateTime.Now.Year - birthYear;
        } 
        public void Output()
        {
            Console.WriteLine($"{Color} animal was born in {BirthYear}, his age is {GetAge(BirthYear)}");
        }

        public override string ToString()
        {
            return $"{Color} animal was born in {BirthYear}, his age is {GetAge(BirthYear)}";
        }
    }
}
