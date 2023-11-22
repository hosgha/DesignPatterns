using System;

namespace HouseBuilder
{
    internal class HouseBuilder : IHouseBuilder
    {
        private House _house;
        public HouseBuilder()
        {
            Reset();
        }

        private void Reset()
        {
            _house = new House();
        }
        public void AddRoof()
        {
            Console.WriteLine("Roof added!");
        }

        public void AddWalls()
        {
            Console.WriteLine("Walls added!");
        }

        public void AddWindows()
        {
            Console.WriteLine("Windows added!");
        }

        public void AddGarden()
        {
            Console.WriteLine("Garden added!");
        }

        public void AddPool()
        {
            Console.WriteLine("Pool added!");
        }

        public void AddYard()
        {
            Console.WriteLine("Yard added!");
        }

        public House GetHouse()
        {
            House house = _house;
            Reset();
            return house;
        }
    }
}
