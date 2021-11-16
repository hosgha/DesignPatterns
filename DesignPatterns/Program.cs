using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Simple Factory Pattern";
            //get an object of Circle and call its Draw method.
            IShape shape1 = ShapeFactory.GetShape(ShapeType.Circle);
            //call draw method of Circle
            shape1.Draw();

            //get an object of Rectangle and call its Draw method.
            IShape shape2 = ShapeFactory.GetShape(ShapeType.Rectangle);
            //call draw method of Rectangle
            shape2.Draw();

            //get an object of Square and call its Draw method.
            IShape shape3 = ShapeFactory.GetShape(ShapeType.Square);
            //call draw method of square
            shape3.Draw();

            Console.ReadKey();
        }
    }
    public interface IShape
    {
        void Draw();
    }
    public class ShapeFactory
    {
        //use GetShape method to get object of type shape 
        public static IShape GetShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.Circle:
                    return new Circle();

                case ShapeType.Rectangle:
                    return new Rectangle();

                case ShapeType.Square:
                    return new Square();

                default:
                    return null;
            }
        }
    }
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
    public enum ShapeType
    {
        Circle,
        Rectangle,
        Square
    }
}
