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
            
            List<Person> staff = new List<Person>() ;
            staff.Add(new Staff("\t\tTaras", 250));
            staff.Add(new Staff("\t\tIhor", 2000));
            staff.Add(new Staff("\t\tOleh", 2000));
            staff.Add(new Staff("\t\tDasha", 250));
            staff.Add(new Teacher("\t\tVlad", 400, "\tC#"));
            staff.Add(new Teacher("\t\tVova", 450, "\tJava"));
            staff.Add(new Teacher("\t\tMykola", 500, "\tRuby"));
            staff.Add(new Developer("\tTania", 700, "\tMidle"));
            staff.Add(new Developer("\tSeveryn", 750, "\tJunior"));
            staff.Add(new Developer("\tAndrew", 750, "\tSenior"));
            
            List<Staff> employees = new List<Staff>(); //Task 8.6???????



            

            
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
            staff.Sort();
            string pathSorted = @"D:\\Projects_C#\\Presentation8\\Task_Presentation8\\Task_Presentation8\\Sorted.txt";
            using (StreamWriter writer = new StreamWriter(pathSorted))
            {
                foreach(var s in staff)
                {
                    writer.WriteLine(s.ToString());
                }
                writer.Close();
            }

            foreach (var s in staff)
            {
                employees.Add(new Staff(s.));
            }

            
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


        public class Staff : Person
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



            
        }


        public class Teacher : Staff
        {
            private string subject;
            virtual public string Subject{ get { return subject; } }

            public Teacher(string name, int salary, string subject) : base(name,salary)
            {
                this.subject = subject;
            }
            public override int Salary { get { return base.alary; } }
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
