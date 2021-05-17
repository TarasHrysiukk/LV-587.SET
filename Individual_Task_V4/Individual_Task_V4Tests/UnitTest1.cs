using Microsoft.VisualStudio.TestTools.UnitTesting;
using Individual_Task_V4;
using System;
using System.IO;
using System.Collections.Generic;

namespace Individual_Task_V4Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            Animal animal = new Animal(new DateTime(2020,02,02).Date,"green");
            //return $"{Color} animal was born in {BirthYear.ToString("dd/MM/yyyy")}, his age is {GetAge(BirthYear)}, he say - " + Voice();
            string expectedRes = $"green animal was born in 02.02.2020, his age is 1, he say - I am an animal!";
            string actualRes = animal.ToString();
            Assert.AreEqual(expectedRes, actualRes);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<Animal> ff = new List<Animal>();
            ff.Add(new Animal(new DateTime(2020, 02, 02).Date, "green"));
            //ff.Add(new Animal(new DateTime(2020, 02, 02).Date, "white"));
            string expectedRes = "green animal was born in 02.02.2020, his age is 1, he say - I am an animal!";
             // $" white animal was born in 02.02.2020, his age is 1, he say - I am an animal!";
            Program.WriteinFile(ff);
            string path = @"D:\Projects_C#\Individual_Task_V4\Individual_Task_V4\IndidvidualTaskV4.txt";
            string actualdRes = " ";
            using (StreamReader reader = new StreamReader(path))
            {
                 actualdRes =  reader.ReadLine();
            }
            Assert.AreEqual(expectedRes, actualdRes);
        }
    }
}
