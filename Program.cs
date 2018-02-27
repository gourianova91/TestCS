using System;

namespace ShapeCS
{
    class Program
    {
        abstract class Shape
        {
            public abstract void move(int x, int y);
            public abstract void scale(int scaleF);
            public abstract void rotate(float angle);
        }
        class Circle : Shape
        {
            public float getRadius { get; set; }
            public Circle(float radius) 
            {
                getRadius = radius;
                Console.WriteLine($"Circle's radius = {radius}");
            }
            public override void move(int x, int y)
            {
                Console.WriteLine($"Circle is moved to ({x}, {y}) position");
            }
            public override void scale(int scaleF)
            {
                Console.WriteLine($"Circle is scaled to {scaleF} size");
            }
            public override void rotate(float angle)
            {
                Console.WriteLine($"Circle is rotated to {angle}°");
            }
        }
        class Square : Shape 
        {
            public int getX { get; set; }
            public Square(int x) 
            {
                getX = x;
                Console.WriteLine($"Square's side = {x}");
            }
            public override void move(int x, int y)
            {
                Console.WriteLine($"Square is moved to ({x}, {y}) position");
            }
            public override void scale(int scaleF)
            {
                Console.WriteLine($"Square is scaled to {scaleF} size");
            }
            public override void rotate(float angle)
            {
                Console.WriteLine($"Square is rotated to {angle}°");
            }
        }
        class Rectangle : Shape
        {
            public int getX { get; set; }
            public int getY {get; set; }
            public Rectangle(int x, int y)
            {
                getX = x;
                getY = y;
                Console.WriteLine($"Rectangle's sides are {x}, {y}");
            }
            public override void move(int x, int y)
            {
                Console.WriteLine($"Rectangle is moved to ({x}, {y}) position");
            }
            public override void scale(int scaleF)
            {
                Console.WriteLine($"Rectangle is scaled to {scaleF} size");
            }
            public override void rotate(float angle)
            {
                Console.WriteLine($"Rectangle is rotated to {angle}°");
            }
        }
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);
            circle.move(2, 2);
            circle.scale(5);
            circle.rotate(30);
            Console.WriteLine();
            Rectangle rectangle = new Rectangle(5, 10);
            rectangle.move(1, 3);
            rectangle.scale(10);
            rectangle.rotate(45);
            Console.WriteLine();
            Square square = new Square(5);
            square.move(1, 6);
            square.scale(6);
            square.rotate(12.2f);
        }
    }
}
