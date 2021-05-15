using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

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
-	 Output the data about birds older than 3 years
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
    public class Animal 
    {
        DateTime birthYear;
        //var date =  
        public DateTime BirthYear { get { return birthYear.Date; } set { birthYear = value; } }
        public virtual  string Color { get; set; }

        public Animal() { }
        public Animal(DateTime birthYearAnimal, string colorAnimal)
        {
            BirthYear = birthYearAnimal;
            Color = colorAnimal;
        }
        public virtual string Voice()
        {
            return "I am an animal!";
        }

        public virtual void Input()
        {
            Console.WriteLine("Enter date of birth this animal");
            DateTime birthDateYourAnimal = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter color of your animal: ");
            string yourAnimalColor = Console.ReadLine();
            BirthYear= birthDateYourAnimal.Date;
            Color = yourAnimalColor;
        }

        public virtual void Output()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"{Color} animal was born in {BirthYear.ToString("dd/MM/yyyy")}, his age is {GetAge(BirthYear)}, he say - " + Voice();
        }
        public virtual int GetAge(DateTime birthYear)
        {
            return DateTime.Now.Year - birthYear.Year;
        }
    }

    public class Bird : Animal, IComparable<Bird>
    {

        public string species;
        public string Species { get { return species; } set { species = value; } }
        public int EggsCount { get; set; }
        
        public Bird() { }

        public Bird(string species, int eggsCount, DateTime birthYear, string color): base(birthYear.Date, color)
        {
            Species = species;
            EggsCount = eggsCount;
            base.Color = color;
            base.BirthYear = birthYear;
           
        }

        public override string Voice()
        {
            return "I am an Bird!";
        }

        public override void Input()
        {
            Console.WriteLine("Enter date of birth this Bird");
            DateTime birthDateYourBird = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter color of your bird: ");
            string yourBirdColor = Console.ReadLine();
            Console.WriteLine("Enter species of the bird");
            string species = Console.ReadLine();
            Console.WriteLine("How many eggs this bird have?");
            int eggsCount = Convert.ToInt32(Console.ReadLine());
            Species = species;
            EggsCount = eggsCount;
            base.BirthYear = birthDateYourBird;
            base.Color = yourBirdColor;
        }
         
        public override void Output()
        {
            Console.WriteLine(ToString());              
        }
        public override string ToString()
        {

            return $"{base.Color} {Species} was born in {base.BirthYear.ToString("dd/MM/yyyy")} has {EggsCount} eggs, his age is \"{GetAge(base.BirthYear)} y.o.\" he say - " + Voice();
        }

        public override int GetAge(DateTime birthYear)
        {
            return DateTime.Now.Year - birthYear.Year;
        }
        public int CompareTo(Bird bird)
        {
            return this.Species.CompareTo(bird.Species);
        }
    }

    class Program : IComparable<Bird>
    {
        static void Main(string[] args)
        {
            //List<Bird> animals = new List<Bird>();                        // Sort???
            List<Animal> animals = new List<Animal>();
            InputList();
            var adultAnimal = from i in animals
                              where (i.GetAge(i.BirthYear)) > 3
                              select i;
            Console.WriteLine("Bird older than 3 years");
            foreach (var res in adultAnimal)
            {
                if (res is Bird)
                {
                    res.Output();
                }
            }

            //var sorted = animals.OrderBy(animal => animal.Species);       //Sort

            //foreach(var sort in sorted)                                   //Sort               
            //{

            //    sort.Output();                                            //Sort
            //}

            //animals.Sort();                                               //Call Sort
            
           // OutputList();                                                 //output after sort
            void InputList()
            {
                try
                {
                    Animal inputAnimal;
                    Bird inputBird;
                    for (int i = 0; i < 1; i++)
                    {
                        Console.WriteLine("You wanna enter: 1 - bird; 2 - another animal");
                        string youChoice = Console.ReadLine();
                        switch (youChoice)
                        {
                            case "1":
                                {
                                    inputBird = new Bird();
                                    inputBird.Input();
                                    animals.Add(inputBird);
                                    break;
                                }

                            case "2":
                                {
                                    inputAnimal = new Animal();
                                    inputAnimal.Input();
                                    animals.Add(inputAnimal);
                                    break;
                                }
                            default:
                                throw new Exception($"Invalid  arguments, Must be 1 or 2, NOT - \"{youChoice}\"");
                        }
                    }
                    OutputList();
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            void OutputList()
            {
                foreach (Animal animal in animals)
                {
                    animal.Output();
                }
            }
        }

        public int CompareTo(Bird bird)
        {
            
            return bird.CompareTo(bird);
        }
    }
}
