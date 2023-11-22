using System;

namespace SingleTonePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SingleTone Pattern";

            //illegal construct
            //Compile Time Error: The constructor SingleObject() is not visible
            //SingleObject object = new SingleObject();

            //Get the only object available
            SingleToneClass obj1 = SingleToneClass.GetInstance();
            obj1.Name = "Dog";

            SingleToneClass obj2 = SingleToneClass.GetInstance();
            obj2.Name = "Cat";

            Console.WriteLine(obj1.Name);

            Console.ReadKey();
        }
    }

    public sealed class SingleToneClass
    {

        //create an object of SingleObject
        private static SingleToneClass instance;

        // Safe Code for Multi Thread Environment
        private static object _lock = new object(); 

        //make the constructor private so that this class cannot be
        //instantiated
        private SingleToneClass() { }

        //Get the only object available
        public static SingleToneClass GetInstance()
        {
            if (instance == null)
            {   lock (_lock)
                {
                    instance = new SingleToneClass();
                }
            }

            return instance;
        }

        public string Name { get; set; }
    }
}
