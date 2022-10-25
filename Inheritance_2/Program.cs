using System;
using System.Text;
using System.Linq;

namespace Inheritance_2
{
    class Program
    {
        // Inheritance and Polymorphism( virtual, abstract, interfaces)
        abstract class Shape
        {
            public abstract void Type();

        }
        class Circle:Shape
        {
            public override void Type()
            {
                Console.WriteLine("This is a circle");
            }
        }
        class Rect:Shape
        {
            public override void Type()
            {
                Console.WriteLine("This is a rectangle");
            }
        }
        static void Main(string[] args)
        {
            Shape rect = new Rect();
            Shape circle = new Circle();
            rect.Type();
            circle.Type();
        }
    }
}