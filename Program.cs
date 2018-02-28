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
            public Circle()
            {
                Console.WriteLine("Circle is created");
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
            public Square()
            {
                Console.WriteLine("Square is created");
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
            public Rectangle()
            {
                Console.WriteLine("Rectangle is created");
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
        abstract class Creator
        {
            // factory method
            public abstract Shape create_shape();
        }
        class CircleCreator : Creator
        {
            public override Shape create_shape()
            {
                return new Circle();
            }
        }
        class SquareCreator : Creator
        {
            public override Shape create_shape()
            {
                return new Square();
            }
        }
        class RectangleCreator : Creator
        { 
            public override Shape create_shape()
            {
                return new Rectangle();
            }
        }
        static void Main(string[] args)
        {
            Creator creator = new CircleCreator();
            Shape shape1 = creator.create_shape();

            creator = new SquareCreator();
            Shape shape2 = creator.create_shape();

            creator = new RectangleCreator();
            Shape shape3 = creator.create_shape();
        }
    }
}
