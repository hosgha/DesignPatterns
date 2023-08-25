using System;

namespace HouseBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HouseDirector houseDirector = new HouseDirector();            
            IHouseBuilder houseBuilder = new HouseBuilder();
            houseDirector.HouseBuilder = houseBuilder;

            Console.WriteLine("Generating a Base House... ");
            houseDirector.GetBaseHouse();

            Console.WriteLine("\nGenerating a Mid House... ");
            houseDirector.GetMidHouse();

            Console.WriteLine("\nGenerating a Luxury House... ");
            houseDirector.GetLuxuryHouse();

            // Specific house that is not contained in diractor
            Console.WriteLine("\nGenerating a Specific House... ");
            houseBuilder.AddWalls();
            houseBuilder.AddRoof();
            houseBuilder.AddWindows();
            houseBuilder.AddPool();

        }
    }
}
