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
            public Circle() 
            {
                Console.WriteLine($"This is a circle");
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
            public Square() 
            {
                Console.WriteLine($"This is a square!");
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
            public Rectangle()
            {
                Console.WriteLine($"This is a rectangle!");
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
            Circle circle = new Circle();
            circle.getRadius  = 3;
            circle.move(0, 0);
            circle.create_shape("Circle", radius: circle.getRadius);
            Rectangle rectangle = new Rectangle();
            rectangle.getX = 5;
            rectangle.getY = 10;
            rectangle.move(0, 0);
            rectangle.create_shape("Rectangle", x: rectangle.getX, y: rectangle.getY);
            Square square = new Square();
            square.getX = 5;
            square.move(0, 0);
            square.create_shape("Square", x: square.getX);
        }
    }
}
