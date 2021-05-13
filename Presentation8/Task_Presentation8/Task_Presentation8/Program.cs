using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.IO;

namespace Task_Presentation8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Person> persons = new List<Person>() ;
            //persons.Add(new Staff("\t\tTaras", 250));
            //persons.Add(new Staff("\t\tIhor", 2000));
            //persons.Add(new Staff("\t\tOleh", 2000));
            //persons.Add(new Staff("\t\tDasha", 250));
            persons.Add(new Teacher(" \tVlad", 400, "\tC#"));
            persons.Add(new Teacher(" \tVova", 450, "\tJava"));
            persons.Add(new Teacher(" \tMykola", 500, "\tRuby"));
            persons.Add(new Developer(" \tTania", 700, "\tMidle"));
            persons.Add(new Developer(" \tSeveryn", 750, "\tJunior"));
            persons.Add(new Developer(" \tAndrew", 750, "\tSenior"));
            
            


            

            
            foreach (Person person in persons)
            {
                person.Print();
            }
            Console.WriteLine("Enter randome Persone name");
            string personeName = Console.ReadLine();
            int count = 0;
            foreach (var s in persons)
            {
                
                if (s.Name.Contains(personeName))
                {
                    Console.WriteLine("This Person is present in Staff:");
                    s.Print();
                    break;
                }
                else if((persons.Count).Equals(count+1))
                {
                    Console.WriteLine("This Person is not in the staff");
                }
                else
                {
                    count++;
                }
            }
            persons.Sort();
            string pathSorted = @"D:\\Projects_C#\\Presentation8\\Task_Presentation8\\Task_Presentation8\\Sorted.txt";
            using (StreamWriter writer = new StreamWriter(pathSorted))
            {
                foreach(Person person in persons)
                {
                    writer.WriteLine(person.Name);
                    Console.WriteLine(person.Name);
                }
                writer.Close();
            }

            List<Staff> employees = new List<Staff>(); //Task 8.6???????
            foreach (Person person in persons)
            {
                if (person is Staff)
                {
                    employees.Add(person as Staff);
                }
            }
            employees.Sort();

        }


        public class Person: IComparable<Person>
        {
            private string name;
            public  Person(string name)
            {
                this.name = name;
            }
            virtual public string Name { get { return name; } }

            virtual public void Print()
            {
                Console.WriteLine($"Name : { this.name}");
            }

            public int CompareTo(Person person)
            {
               return this.Name.CompareTo(person.name);
            }
        }


        public class Staff : Person, IComparable<Staff>
        {
            private int salary;
            public virtual int Salary { get { return salary; } }
            public Staff(string name, int salary) : base(name)
            {
                this.salary = salary;
            }
            public override string Name { get { return base.Name + " -Staff"; } }

            override public void Print()
            {
                Console.WriteLine($"Person {Name} has salary {this.salary}");
            }

            public int CompareTo(Staff staff)
            {
                return this.salary.CompareTo(staff.salary);
            }
        }


        public class Teacher : Staff
        {
            private string subject;
            virtual public string Subject{ get { return subject; } }

            public Teacher(string name, int salary, string subject) : base(name,salary)
            {
                this.subject = subject;
            }
            //public override int Salary { get { return salary; } }
            public override string Name { get { return base.Name + " -Teacher"; } }
            public override void Print()
            {
                Console.WriteLine($"Teacher{Name} teach {subject} subject has salary {Salary} ");
            }

        }


        public class Developer : Staff
        {
            private string level;
            virtual public string Level { get { return level; } }

            public Developer(string name, int salary, string level) : base(name, salary)
            {
                this.level = level;
            }

            override public string Name { get { return base.Name + " -Developer"; } }
            public override void Print()
            {
                Console.WriteLine($"Developer{Name} hi is {Level} and has salary {Salary}");
            }

        }
    }
}
