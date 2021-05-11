using System;
using System.Collections.Generic;
using System.IO;

namespace HmWrk_Presentation7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = @"D:\\Projects_C#\\Presentation7\\HmWrk_Presentation7\\HmWrk_Presentation7\\FilesFromHomeWork\\phones.txt";
            string newPath = @"D:\\Projects_C#\\Presentation7\\HmWrk_Presentation7\\HmWrk_Presentation7\\FilesFromHomeWork\\Phones2.txt";
            string newTxt = @"D:\\Projects_C#\\Presentation7\\HmWrk_Presentation7\\HmWrk_Presentation7\\FilesFromHomeWork\\New.txt";
            Dictionary<string , string> PhoneBook = new Dictionary<string, string>();
            StreamWriter writer = new StreamWriter(newPath);
            StreamWriter writerNew = new StreamWriter(newTxt);
            using (StreamReader reader = new StreamReader(path, true))
            {


                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] parts = line.Split('-');
                    PhoneBook.Add(parts[0], parts[1]);
                    writer.WriteLine(parts[1]);
                }


                reader.Close();
                writer.Close();
                //Console.WriteLine(PhoneBook.ToString());
            }
                Console.WriteLine("whose number you want?");
                string whoseNumber = Console.ReadLine();
                Console.WriteLine($"{whoseNumber}'s number - {PhoneBook[whoseNumber]}");
            using(StreamReader readerPhones2 = new StreamReader(newPath))
            {
                
                string line2;
                while ((line2 = readerPhones2.ReadLine()) != null)
                {
                    if (line2.StartsWith("80"))
                    {
                        writerNew.WriteLine($"+3{line2}");
                    }
                }
                readerPhones2.Close();
                writerNew.Close();
            }
            
                

            
            


        }
    }
}
