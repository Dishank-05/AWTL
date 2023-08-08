
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace prac3_3_Area
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public override double GetArea()
        {
            return length * width;
        }
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }
        public override double GetArea()
        {
            return 3.14 * radius * radius;
        }
    }
    class Ellipse : Shape
    {
        private double majorAxis;
        private double minorAxis;

        public Ellipse(double maj, double min)
        {
            majorAxis = maj;
            minorAxis = min;
        }
        public override double GetArea()
        {
            return 3.14 * majorAxis * minorAxis;
        }
    }

    class Square : Shape
    {
        public double side;

        public Square(double s)
        {
            side = s;
        }
        public override double GetArea()
        {
            return side * side;
        }
    }

    class Triangle : Shape
    {
        private double baseLength;
        private double height;

        public Triangle(double bl, double h)
        {
            baseLength = bl;
            height = h;
        }

        public override double GetArea()
        {
            return 0.5 * baseLength * height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("Program to find out Area for different Shapes Implemented by Rushikesh_21");
                Console.WriteLine("Please Choose a Shape to find the area");
                Console.WriteLine("1.Rectangle");
                Console.WriteLine("2.Circle");
                Console.WriteLine("3.Ellipse");
                Console.WriteLine("4.Square");
                Console.WriteLine("5.Triangle");
                Console.WriteLine("6.Exit");
                Console.WriteLine("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the length of the Rectangle");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the width of the Rectangle");
                        double width = Convert.ToDouble(Console.ReadLine());

                        Rectangle rect = new Rectangle(length, width);
                        Console.WriteLine("Area of Rectangle = " + rect.GetArea());
                        break;

                    case 2:
                        Console.WriteLine("Enter the radius of the Circle");
                        double radius = Convert.ToDouble(Console.ReadLine());

                        Circle cir = new Circle(radius);
                        Console.WriteLine("Area of Circle = " + cir.GetArea());
                        break;

                    case 3:
                        Console.WriteLine("Enter the major axis of Ellipse");
                        double majorAxis = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the minor axis of Ellipse");
                        double minorAxis = Convert.ToDouble(Console.ReadLine());

                        Ellipse ep = new Ellipse(majorAxis, minorAxis);
                        Console.WriteLine("Area of the Ellipse = " + ep.GetArea());
                        break;

                    case 4:
                        Console.WriteLine("Enter the side of the Square");
                        double side = Convert.ToDouble(Console.ReadLine());

                        Square sq = new Square(side);
                        Console.WriteLine("Area of Square = " + sq.GetArea());
                        break;


                    case 5:
                        Console.WriteLine("Enter the baseLength of triangle");
                        double baseLength = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter the Height of Triangle");
                        double height = Convert.ToDouble(Console.ReadLine());

                        Triangle tr = new Triangle(baseLength, height);
                        Console.WriteLine("Area of Triangle = " + tr.GetArea());
                        break;

                    case 6:
                        {
                            Environment.Exit(6);
                            Console.WriteLine("Exit");
                            break;
                        }

                    default:

                        Console.WriteLine("INVALID CHOICE! Please enter Valid Choice between 1 to 6");
                        break;
                }
            }

            while (i < 5);
            Console.ReadKey();
        }
    }


}

