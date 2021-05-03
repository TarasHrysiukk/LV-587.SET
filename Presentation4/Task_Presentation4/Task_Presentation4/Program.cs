using System;
using System.Collections.Generic;
/// <summary>
/// Print () - to output the machine data to the console ????
/// Overload the operator == for the class Car (cars - equal if the name and price are equal) ????

/// </summary>
namespace Task_Presentation4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Car> cars = new List<Car>();
            cars.Add(new Car());
            cars.Add(new Car("Audi","Yellow",200));

            cars.Add(new Car().input());
            cars.Add(new Car().input());
            cars.Add(new Car().input());
             
            //Change color start
            Console.WriteLine("Want Change Color");
            string colorChanger = Console.ReadLine();
            foreach (Car aCar in cars)
            {
                Console.WriteLine(aCar);
            }
            switch (colorChanger)
            {
                case "yes":
                    Console.WriteLine("which car");
                    string carColorChanger = Console.ReadLine();
                    var carWichYouChange = cars.Find(c => c.CarName == carColorChanger);
                    Console.WriteLine("You choose: " + carWichYouChange);
                    Console.WriteLine("Enter new Color");
                    string newColor = Console.ReadLine();
                    carWichYouChange.CarColor = newColor;
                    Console.WriteLine(carWichYouChange);
                    break;

                case "no":

                    break;
            }
            //Change color end

            foreach (Car aCar in cars)
            {
                Console.WriteLine(aCar);
            }

            Console.WriteLine("Want discount 10% ? ");
            string wantDiscount = Console.ReadLine();
            switch (wantDiscount)
            {
                case "yes":
                    var carWichYouChange = cars.Find(c => c.CarPrice > 0);
                    carWichYouChange.CarPrice = 0.9;        //????????????????чи правльно так міняти ціну. 0,9 бо знижка 10%
                    break;

                case "no":
                    break;
            }
            //вивід на екран ліста
            foreach (Car aCar in cars)
            {
                Console.WriteLine(aCar);
            }

        }


        

            class Car
        {
            string carName;
            string carColor;
            double carPrice;
            const string CompanyName = "Taras";

            public Car()
            {
                carName = "Ford";
                carColor = "Gray";
                carPrice = 10000;
            }

            public Car(string carNamen, string carColorn, double carPricen)
            {
                carName = carNamen;
                carColor = carColorn;
                carPrice = carPricen;
            }

            public double CarPrice
            {
                get
                {
                    return carPrice;
                }

                set
                {
                    carPrice =carPrice * value;         //?????????????????
                }
            }

            public string CarName
            {
                get
                {
                    return carName;
                }
            }
            public string CarColor
            {
                get
                {
                    return carColor;
                }

                set
                {
                    carColor = value;
                }
            }



            
            public Car input()
            {
                Console.WriteLine("Enter car name:");
                carName = Console.ReadLine();
                Console.WriteLine("Enter car Color:");
                carColor = Console.ReadLine();
                Console.WriteLine("Enter car Price:");
                carPrice = Convert.ToInt32(Console.ReadLine());

                return new Car(carName, CarColor, carPrice);
            }

            public override string ToString()
            {
                return "Car Name: " + carName+ "   Car Color: " + carColor + "   Car Price: " +carPrice +
                    "   Company Name: "+CompanyName;
            }
        }
    }
}
