using System;
using System.Collections.Generic;
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
        //DateTime curentYear = DateTime.Now.Year;
        string color;

        public DateTime BirthYear { get; set; }
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
            Console.WriteLine("Enter color of your animal: ");
            string yourAnimalColor = Console.ReadLine();
            Console.WriteLine("Enter date of birth this animal");
            DateTime birthDateYourAnimal = Convert.ToDateTime(Console.ReadLine());
            BirthYear = birthDateYourAnimal;
            Color = yourAnimalColor;
        }

       
        public virtual void Output()
        {
            Console.WriteLine(ToString());
            //Console.WriteLine(Voice());
        }

        public override string ToString()
        {
            return $"{Color} animal was born in {BirthYear}, his age is {GetAge(BirthYear)}";
        }
        public int GetAge(DateTime birthYear)
        {
            return DateTime.Now.Year - birthYear.Year;
        }

        


    }

    public class Bird : Animal, IComparable<Bird>
    {
 
        public string Species { get; set; }
        public int EggsCount { get; set; }
        
        public Bird()
        {
            

        }
        public Bird(string species, int eggsCount, DateTime birthYear, string color): base(birthYear,color)
        {
            Species = species;
            EggsCount = eggsCount;
           
        }

        public override string Voice()
        {
            return "I am an Bird!";
        }

        public override void Input()
        {
            Console.WriteLine("Enter species of the bird");
            string _species = Console.ReadLine();
            Console.WriteLine("How many eggs this bird have?");
            int _eggsCount = Convert.ToInt32(Console.ReadLine());
            Species = _species;
            EggsCount = _eggsCount;
        }
         
        public override void Output()
        {
            Console.WriteLine(ToString());

        }
        public override string ToString()
        {

            return $"Bird species \"{Species}\" has {EggsCount} eggs" + Voice();
        }

        public int CompareTo(Bird bird)
        {
            return this.Species.CompareTo(bird.Species);
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
            foreach (var res in adultAnimal)
            {
                if(res is Animal)
                {
                    Console.WriteLine("Animals older than 3 years");
                    res.Output();
                }
                
            }

            //animals.Sort();
            void InputList()
            {
                try
                {
                    Animal inputAnimal;
                    Bird inputBird;
                   // SpeciesOfBird speciesEnum;
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("You wanna enter: 1 - bird; 2 - another animal");
                        string youChoice = Console.ReadLine();
                        switch (youChoice)
                        {
                            case "1":
                                {
                                    //must be input from bird
                                    //Bird testc = new Bird();
                                    //testc.Input();
                                    Console.WriteLine("Enter species of the bird");
                                    string _species = Console.ReadLine();
                                    Console.WriteLine("How many eggs this bird have?");
                                    int _eggsCount = Convert.ToInt32(Console.ReadLine());
                                    var k = new DateTime(2020,01,01);
                                    inputBird = new Bird(_species, _eggsCount,k ,"wsfd");
                                    animals.Add(inputBird);
                                    Console.WriteLine($"{_species} have {_eggsCount}");
                                    Console.WriteLine();
                                    break;
                                }

                            case "2":
                                {
                                    //must be input from animal
                                    Console.WriteLine("Enter color of your animal: ");
                                    string yourAnimalColor = Console.ReadLine();
                                    Console.WriteLine("Enter date of birth this animal");
                                    DateTime birthDateYourAnimal = Convert.ToDateTime(Console.ReadLine());
                                    inputAnimal = new Animal(birthDateYourAnimal, yourAnimalColor);
                                    animals.Add(inputAnimal);
                                    Console.WriteLine($"{yourAnimalColor} animal was born in {birthDateYourAnimal}");
                                    Console.WriteLine();
                                    break;
                                }
                            default:
                                throw new Exception($"Invalid  arguments, Must be 1 or 2, NOT - \"{youChoice}\"");
                                break;

                        }
                    }


                    foreach (Animal animal in animals)
                    {
                        animal.Output();
                    }
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

        }
    }
    enum SpeciesOfBird
    {
        Sparrow,
        Gogol,
        Dove,
        Falcon,
        Eagle
    }

}
