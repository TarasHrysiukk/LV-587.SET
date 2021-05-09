using System;
using System.Collections.Generic;

namespace HmWork_Presenation5
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<uint, string> persons = new Dictionary<uint, string>();
            /*Programer programer = new Programer();
            Builder builder = new Builder();
            List<string> arrProgAndBulder = new List<string>();
            Console.WriteLine("Now add 2 programer");
            for(int i = 0 ; i < 2 ; i++)
            {
                programer.Create(arrProgAndBulder);
            }
            Output(arrProgAndBulder);
            Console.WriteLine("\tNow add 2 builder");
            for (int i = 0; i < 2; i++)
            {
                builder.Create(arrProgAndBulder);
            }
            Output(arrProgAndBulder);
            programer.Destroy(arrProgAndBulder);
            Console.WriteLine( "\tafter destroy" );
            Output(arrProgAndBulder);
            builder.Destroy(arrProgAndBulder);
            Console.WriteLine("\tafter second destroy");
            Output(arrProgAndBulder);
            arrProgAndBulder.Sort();
            Console.WriteLine("\tafter sort");
            Output(arrProgAndBulder);*/

            Console.WriteLine("Now nnter name which you have add to dictionary");

            uint count = 1;
            for (int i = 0; i < 3; i++)
            {
                
                Console.WriteLine($"Enter name {count}");
                string name = Console.ReadLine();
                persons.Add(count,name);
                count++;
            }


            Console.WriteLine("Which id find? ");
            uint IdPerson = Convert.ToUInt32(Console.ReadLine());
            try
            {
                if (IdPerson == null)
                {
                    Console.WriteLine("Error id");
                }
                else
                {
                    string namePerson = persons[IdPerson];
                    Console.WriteLine("Person which you want - " + namePerson);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error ID");
            }
            
            






            void Output(List<string> arr)
            {
                //string[] arrOutput = new string[arr.Count];
                foreach (var el in arr )
                {
                    Console.WriteLine(el);

                }
            }
        }
    }

    public interface IDeveloper
     {
         string Tool { get; set; }


        void Create(List<string> arr);


        void Destroy(List<string> arr);
        
    }

    class Programer : IDeveloper, ICloneable
    {


        string language;
        public string Tool
        {
            get => language;
            set => language = value;
        }

        public void Create( List<string> arr)
        {
         
            Console.WriteLine("enter program language");
            Tool = Console.ReadLine();
            arr.Add(language);
            
        }

        int count = 0;
        public void Destroy(List<string> arr)
        {
            arr.RemoveAt(count);
            this.count++;

        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }

    class Builder : IDeveloper
    {
        private string tool;
        public string Tool
        {
            get => tool;
            set => tool = value;
        }

        public void Create(List<string> arr)
        {

            Console.WriteLine("enter builder");
            Tool = Console.ReadLine();
            arr.Add(tool);

        }

        int count = 2;
        public void Destroy(List<string> arr)
        {
            arr.RemoveAt(count);
            this.count++;

        }
    }
     
}
