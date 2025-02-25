using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003.Abstract
{
    public abstract class Shape
    {
        double length;  //1 
        double height;  //2

        public Shape(double length, double height)  //3  non-abstract
        {
            this.length = length;
            this.height = height;
        }

        public double getLength() { return length; }    //4 non-abstract
        public double getHeight() { return height; }    //5 non-abstract

        public abstract double getArea();   //6 members in there 
    }
    public class Rectangle : Shape
    {
        public Rectangle(double length, double height) : base(length , height){ }

        public override double getArea()
        {
            return (getLength() * getHeight());
        }
    }
    class abdemo
    {
        public static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 5);
            Console.WriteLine("Rectangle Area: " + rect.getArea());
        }
    }
}