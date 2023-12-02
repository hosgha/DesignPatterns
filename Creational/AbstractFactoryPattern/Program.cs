using System;

namespace AbstractFactoryPattern
{
    //Step 6 : Use the FactoryProducer to get AbstractFactory in order to get factories of concrete classes by passing an information such as type.
    class Program
    {       
        static void Main(string[] args)
        {
            bool IsRounded = true;
            Console.Title = "Abstract Factory Pattern";
            //=================(rounded IShape)=====================
            //get rounded IShape factory
            AbstractFactory IShapeFactory1 = FactoryProducer.getFactory(IsRounded);
            
            //get an object of IShape Rectangle
            IShape shape3 = IShapeFactory1.GetShape(ShapeType.Rectangle);
            //call Draw method of IShape Rectangle
            shape3.Draw();

            //get an object of IShape Square 
            IShape shape4 = IShapeFactory1.GetShape(ShapeType.Square);
            //call draw method of IShape Square
            shape4.Draw();

            //=================(IShape)=====================
            //get IShape factory
            AbstractFactory IShapeFactory = FactoryProducer.getFactory(!IsRounded);

            //get an object of IShape Rounded Rectangle
            IShape shape1 = IShapeFactory.GetShape(ShapeType.Rectangle);
            //call Draw method of IShape Rectangle
            shape1.Draw();

            //get an object of IShape Rounded Square 
            IShape shape2 = IShapeFactory.GetShape(ShapeType.Square);
            //call Draw method of IShape Square
            shape2.Draw();

            Console.ReadKey();
        }
    }

    //Step1 : Create an interface for Shapes and Colors.
    public interface IShape
    {
        void Draw();
    }
    //Step2 : Create concrete classes implementing the same interface.
    public class RoundedRectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside RoundedRectangle::draw() method.");
        }
    }
    public class RoundedSquare : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside RoundedSquare::draw() method.");
        }
    }
    //------------------
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
            Console.WriteLine("Inside Squre::draw() method.");
        }
    }

    //Step 3 : Create an Abstract class to get factories for Normal and Rounded Shape Objects.
    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(ShapeType type);
    }

    //Step 4 : Create Factory classes extending AbstractFactory to generate object of concrete class based on given information.
    public class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.Rectangle:
                    return new Rectangle();

                case ShapeType.Square:
                    return new Square();

                default:
                    return null;
            }
        }
    }
    public class RoundedShapeFactory : AbstractFactory
    {
        public override IShape GetShape(ShapeType type)
        {

            switch (type)
            {
                case ShapeType.Rectangle:
                    return new RoundedRectangle();

                case ShapeType.Square:
                    return new RoundedSquare();

                default:
                    return null;
            }
        }
    }

    //Step 5 : Create a Factory generator/producer class to get factories by passing an information such as Shape
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(bool isRounded)
        {
            if (isRounded)
            {
                return new RoundedShapeFactory();
            }
            else
            {
                return new ShapeFactory();
            }
        }
    }
    
    //enum ShapeType
    public enum ShapeType
    {
        Rectangle,
        Square
    }
}
