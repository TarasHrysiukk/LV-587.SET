using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.IO;

/// <summary>
/* Variant 4
Define a class Animal which contains://///////////////////////////////////////////////////////////////
-    Fields BirthYear, Color                                                        Done
-    Method Voice() that returns a string like “I am an animal!!!”                  Done 
-    Constructor with parameters                                                    Done
-    Input() and output() methods for input / output from / to console              Done
-    Getters and setters                                                            Done
-    Method GetAge() calculating the animals’s age in full years                    Done
-    Overridden ToString() method calling the Voice() method                        Done
Define a descendant class Bird that has:///////////////////////////////////////////////////////////////                                       
-    Additional fields Species, EggsCount                                           Done
-    Constructor with parameters                                                    Done
-    Additional getters and setters                                                 Done
-    Overridden Voice() method                                                      Done
-    Overridden input() and output() methods                                        Done
Create a collection of animals and add some different animals and birds to it.////////////////////////
-	 Output the data about birds older than 3 years                                 Done
-	 Sort the data by Species                                                       Done
-	 Output the collection to a file                                                Done
-	 Implement exception handling                                                   Done
-	 Serialize the collection to XML file                                            XXX
-	 Deserialize it back                                                             XXX
-	 Write unit tests                                                                XXX      
*/
/// </summary>

namespace Individual_Task_V4
{
    public class Animal : IComparable<Animal>
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

        public virtual int CompareTo(Animal other)
        {
            if (other is Bird)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }

    public class Bird : Animal, IComparable<Animal>
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
        public override int CompareTo(Animal other)
        {
            if(other is Bird)
            {
                return Species.CompareTo(((Bird)other).Species);
            }
            else
            {
                return 1;
            }
            
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
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


            animals.Sort();                                                 //Call Sort
            Console.WriteLine();
            
            OutputList();                                                 //output after sort

            string path = @"D:\Projects_C#\Individual_Task_V4\Individual_Task_V4\IndidvidualTaskV4.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach(var animal in animals)
                {
                    writer.WriteLine(animal);
                }
            }
            void InputList()
            {
                try
                {
                    Animal inputAnimal;
                    Bird inputBird;
                    for (int i = 0; i < 3; i++)
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
    }
}
