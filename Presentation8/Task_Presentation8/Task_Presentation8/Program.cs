using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Task_Presentation8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> staff = new List<Person>() ;
            staff.Add(new Staff("Taras", 250));
            staff.Add(new Staff("Ihor", 2000));
            staff.Add(new Staff("oleh", 2000));
            staff.Add(new Staff("Dasha", 250));
            staff.Add(new Teacher("Vlad", 400, "C#"));
            staff.Add(new Teacher("Vova", 450, "Java"));
            staff.Add(new Teacher("Mykola", 500, "Ruby"));
            staff.Add(new Developer("Tania", 700, "Midle"));
            staff.Add(new Developer("Severyn", 750, "Junior"));
            staff.Add(new Developer("Andrew", 750, "Senior"));

           // staff.Sort();
            foreach (var s in staff)
            {
                s.Print();
            }
            Console.WriteLine("Enter randome Persone name");
            string personeName = Console.ReadLine();
            int count = 0;
            foreach (var s in staff)
            {
                
                if (s.Name.Contains(personeName))
                {
                    Console.WriteLine("This Person is present in Staff:");
                    s.Print();
                    break;
                }
                else if((staff.Count).Equals(count+1))
                {
                    Console.WriteLine("This Person is not in the staff");
                }
                else
                {
                    count++;
                }
            }
            

           
        }


        public class Person
        {
            private string name;
            public Person(string name)
            {
                this.name = name;
            }
            virtual public string Name { get { return name; } }

            virtual public void Print()
            {
                Console.WriteLine($"Name : { this.name}");
            }
        }


        public class Staff : Person
        {
            private int salary;
            virtual public int Salary { get { return salary; } }
            public Staff(string name, int salary) : base(name)
            {
                this.salary = salary;
            }
            public override string Name { get { return base.Name + " -Staff"; } }

            override public void Print()
            {
                Console.WriteLine($"Person {Name} has salary {this.salary}");
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
