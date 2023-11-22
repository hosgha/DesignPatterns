using System;

namespace HouseBuilder
{
    internal class HouseDirector
    {
        private IHouseBuilder _houseBuilder;
        public  IHouseBuilder HouseBuilder { set { _houseBuilder = value; } }
        public void GetBaseHouse() 
        {
            _houseBuilder.AddWalls();
            _houseBuilder.AddRoof();
            _houseBuilder.AddWindows();
        }
        public void GetMidHouse()
        {
            GetBaseHouse();
            _houseBuilder.AddYard();

        }
        public void GetLuxuryHouse()
        {
            GetBaseHouse();
            _houseBuilder.AddGarden();
            _houseBuilder.AddPool();
        }
    }
}
