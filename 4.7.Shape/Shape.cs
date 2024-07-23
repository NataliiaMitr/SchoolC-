using System;

namespace _4._7.Shape
{
    public class Shape
    {
        protected double width;
        protected double height;

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public virtual void GetArea()
        {
            double area = width * height;
            Console.WriteLine($"Area of Shape: {area}");
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height) { }

        public override void GetArea()
        {
            double area = width * height;
            Console.WriteLine($"Area of Rectangle: {area}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Shape shape = new Shape(10, 20);
            shape.GetArea();

            Rectangle rectangle = new Rectangle(10, 20);
            rectangle.GetArea();

            object shapeObject = new Shape(15, 25);
            object rectangleObject = new Rectangle(15, 25);

            if (shapeObject is Shape s)
            {
                s.GetArea();
            }

            if (rectangleObject is Rectangle r)
            {
                r.GetArea();
            }
        }
    }
}

