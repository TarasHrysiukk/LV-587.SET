using System;
using System.IO;
using System.Threading.Tasks;
using System.Text;

namespace Task_Presentatin7
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string path = @"D:\\Projects_C#\\Presentation7\\Task_Presentatin7";
            string file1 = @"D:\\Projects_C#\\Presentation7\\Task_Presentatin7\\Task_Presentatin7\\data.txt";
            string file2 = @"D:\\Projects_C#\\Presentation7\\Task_Presentatin7\\Task_Presentatin7\\rez.txt";
            string direcrotories = @"D:\\Projects_C#\\Presentation7\\Task_Presentatin7\\Task_Presentatin7\\DirectoryC.txt";
            try 
            {

                StreamReader reader1 = new StreamReader(file1);

                writeInside(file2);
                
                void writeInside(string file)
                {
                    File.WriteAllText(file, reader1.ReadToEnd());
                    
                }
                Console.WriteLine(reader1.ReadToEnd());
                reader1.Close();

                string dirName = "C:\\";
                string dirNameD = "D:\\Projects_C#";
                if (Directory.Exists(dirName))
                {
                    Console.WriteLine("Dir");
                    string[] dirs = Directory.GetDirectories(dirName);
                    for(int i = 0; i < dirs.Length; i++)
                    {
                        Console.WriteLine(dirs[i]);
                        File.WriteAllText(direcrotories, dirs[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine("файли");
                    string[] files = Directory.GetFiles(dirName);
                    foreach(string s in files)
                    {
                        Console.WriteLine(s);
                        File.WriteAllText(direcrotories, s);
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine("файли");
                    string[] onlyTxt = Directory.GetFiles(dirNameD);
                    foreach (string s in onlyTxt)
                    {
                        if (s.Contains(".txt"))
                        {
                            Console.WriteLine(s);
                        }
                    }

                }

            }
            catch (FileNotFoundException e)
            {
   
                Console.WriteLine("Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
        }
    }
}
