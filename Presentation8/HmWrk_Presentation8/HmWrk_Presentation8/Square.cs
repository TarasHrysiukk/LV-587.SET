using System;
using System.Collections.Generic;
using System.Text;

namespace HmWrk_Presentation8
{
    public class Square : Shape
    {

        private double side;
        public Square(string name, double _side) : base(name)
        {
            Side = _side;
        }
        public double Side 
        {
            get { return side; }
            set
            {
                if(side < 0)
                {
                    Console.WriteLine("Error radius can not be less than 0.");
                }
                else
                {
                    side = value;
                }
            } 
        }

        public override double Area()
        {
            return Math.Pow(side,2);
        }

        public override double Perimetr()
        {
            return side * 4;
        }
    }
}
