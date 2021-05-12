using System;
using System.Collections.Generic;
using System.Text;

namespace HmWrk_Presentation8
{
    public abstract class Shape : IComparable
    {
        private string name;

        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            } 
        }

        public abstract double Area();
        public abstract double Perimetr();

        public Shape(string _name)
        {
            Name = _name;
        }

        public int CompareTo(object compareObject)
        {
            Shape otherObject = (Shape)compareObject;
            return this.Area().CompareTo(otherObject.Area());
        }
    }
}
