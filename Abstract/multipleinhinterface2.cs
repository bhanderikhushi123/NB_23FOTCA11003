using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003.Abstract
{

    public interface IShape
    {
        double GetArea(double length, double height);
    }

    public interface IColour
    {
        string GetColour(string colour);
    }

    public class Rectangles : IShape, IColour
    {
        public double GetArea(double length, double height)
        {
            return length * height;
        }

        public string GetColour(string colour)
        {
            return $"Rectangles Colour: {colour}";
        }
    }

    class multipleinhinterface2
    {
        public static void Main(string[] args)
        {
            Rectangles rect = new Rectangles();
            Console.WriteLine("Rectangle Area: " + rect.GetArea(10, 5));
            Console.WriteLine(rect.GetColour("Red"));
        }
    }
}
