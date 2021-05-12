using System;
using System.Collections.Generic;
using System.Text;

namespace HmWrk_Presentation8
{
    public class Circle : Shape
    {
        private double radius;
        public double Radius 
        {
            get { return radius; }
            set
            {
                if (radius < 0)
                {
                    Console.WriteLine("Error radius can not be less than 0.");
                }
                else
                {
                    radius = value;
                }
            }
        }
        
        public Circle(string name,double _radius): base(name)
        {
            radius = _radius; 
        }
        public override double Area()
        {
            return  Math.PI * Math.Pow(radius,2);
        }

        public override double Perimetr()
        {
            return 2 * Math.PI * radius;
        }
    }
}
