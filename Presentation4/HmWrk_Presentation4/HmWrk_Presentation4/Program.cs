using System;
using System.Collections.Generic;

namespace HmWrk_Presentation4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrPersone = new string[6];
            List<Person> person = new List<Person>();
            person.Add(new Person());
            person.Add(new Person());
            person.Add(new Person());
            person.Add(new Person());
            person.Add(new Person());
            person.Add(new Person());

            foreach (Person aPersone in person)
            {
                aPersone.Input();
            }
            foreach (Person aPersone in person)
            {
                Console.WriteLine(aPersone + "   Age: - " + aPersone.age());

            }
            //Console.WriteLine($" person = person2 - {person[1] == person[2]}");
            Console.WriteLine("Person which Age is less then 16, change name to \"Very Young\" ");
            foreach (Person aPersone in person)
            {
                if (aPersone.age() < 16)
                {
                    aPersone.Name = "Very Young";
                }
                Console.WriteLine(aPersone);
            }

            Console.WriteLine("People with the same names");
            foreach (Person aPersone in person)
            {
                foreach (Person aPerson in person)
                {
                   if( aPersone == aPerson)
                    {
                        Console.WriteLine($"{aPersone.Name}  AND person  {aPerson.Name}    have the same name"); 
                    }

                }

            }

        }
        
        public class Person
        {
            Random rnd = new Random();
            private string name;
            private DateTime birthYear;

            public void Input()
            {
                Console.Write("Enter the name of a person: ");
                name = Console.ReadLine();
                Console.Write("Enter the date of birth of the person: ");
                birthYear = Convert.ToDateTime(Console.ReadLine());
            }

            public Person()
            {
                name = "Taras";
                birthYear = new DateTime(1999, 10, 27, 12, 0, 0);

            }

            public Person(string namen, int birthYearn)
            {
                this.name = namen;
                this.birthYear = new DateTime(birthYearn, rnd.Next(1, 12), rnd.Next(1, 30), rnd.Next(0, 24), rnd.Next(0, 60), rnd.Next(0, 60));

            }
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            public DateTime BirthYear
            {
                get
                {
                    return birthYear;
                }
            }

            public int age()
            {
                DateTime now = DateTime.Today;

                int age = int.Parse(now.ToString("yyyy")) - int.Parse(birthYear.ToString("yyyy"));

                return age;
            }

            /*public changeName()
            {
                name = newName;
            }*/
            public override string ToString()
            {
                return "Name: " + name + "   The birthday year: " + birthYear;
            }

            public static bool operator == (Person person, Person person1)
            {
                return (person.name == person1.name);
            }
            public static bool operator !=(Person person, Person person1)
            {
                return (person.name != person1.name);
            }
        }
    }
}
