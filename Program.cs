using System;

namespace ShapeCS
{
    class Program
    {
        abstract class Shape
        {
            public string type = "Shape";
            public abstract void move(int x, int y);
            public abstract void scale(int scaleF);
            public abstract void rotate(float angle);
            public abstract void create_shape(string type, int x = 0, int y = 0, float radius = 1);
        }
        class Circle : Shape
        {
            private float radius;
            public float getRadius 
            { 
                get { return radius; }
                set { radius = value; }
            }
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
            public override void create_shape(string type, int x = 0, int y = 0, float radius = 1)
            {
                Console.WriteLine($"{type} with radius {radius} is created!");
            }
        }
        class Square : Shape 
        {
            private int x;
            public int getX 
            { 
                get { return x; }
                set { x = value; }
            }
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
            public override void create_shape(string type, int x = 0, int y = 0, float radius = 1)
            {
                Console.WriteLine($"{type} with x = {x} is created!");
            }
        }
        class Rectangle : Shape
        {
            private int x;
            private int y;
            public int getX 
            { 
                get { return x; }
                set { x = value; }
            }
            public int getY 
            {
                get { return y; } 
                set { y = value; } 
            }
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
            public override void create_shape(string type, int x = 0, int y = 0, float radius = 1)
            {
                Console.WriteLine($"{type} with x = {x} and y = {y} is created!");
            }
        }
        static void Main(string[] args)
        {
            Shape shape;
            Shape circle = new Circle(3);
            shape = circle;
            shape.move(0, 0);
            shape.create_shape("Circle", radius: 3);
            Shape rectangle = new Rectangle(5, 10);
            shape = rectangle;
            shape.move(0, 0);
            shape.create_shape("Rectangle", x: 5, y: 10);
            Shape square = new Square(5);
            shape = square;
            shape.move(0, 0);
            shape.create_shape("Square", x: 5);
        }
    }
}
