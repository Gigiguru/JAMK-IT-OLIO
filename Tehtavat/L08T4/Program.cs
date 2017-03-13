using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{

    abstract class Shape
    {

        public double Radius;
        public double Width;
        public double Height;
        public string Name { get; set; }
        public abstract double AREA();
        public abstract double Circumfence();

    }
    class Shapes
    {

        public List<Shape> Shapelist { get; }
        public Shapes()
        {
            Shapelist = new List<Shape>();
        }
    }
    class Circle : Shape
    {
        public Circle() { }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double AREA()
        {
            return 3.14 * (Radius * Radius);
        }
        public override double Circumfence()
        {
            return (2 * 3.14 * Radius);
        }
        public override string ToString()
        {
            return "Circle Radius= " + Radius + " AREA= " + AREA() + " Circumfence= " + Circumfence();
        }

    }
    class Rectangle : Shape
    {
        public Rectangle() { }
        public Rectangle(double widht, double height)
        {
            Width = widht;
            Height = height;
        }
        public override double AREA()
        {
            return (Width * Height);
        }
        public override double Circumfence()
        {
            return (Width + Height) + (Width + Height);
        }
        public override string ToString()
        {
            return "Rectangle Width= " + Width + " Height= " + Height + " AREA= " + AREA() + " Circumfence= " + Circumfence();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Shapes shapes = new Shapes();

            shapes.Shapelist.Add(new Circle(1));
            shapes.Shapelist.Add(new Circle(2));
            shapes.Shapelist.Add(new Circle(3));
            shapes.Shapelist.Add(new Rectangle(10, 20));
            shapes.Shapelist.Add(new Rectangle(20, 30));
            shapes.Shapelist.Add(new Rectangle(40, 50));
            foreach (Shape item in shapes.Shapelist
                )
            {
                Console.WriteLine(item.ToString());
            }



        }


    }

}
