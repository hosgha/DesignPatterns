using Builder.Enums;

namespace Builder
{
    // Concreate Builder
    public class MarutiCarBuilder : ICarBuilder
    {
        private Car _car;

        public MarutiCarBuilder()
        {
            _car = new Car("Maruti");
        }

        public void BuildBody()
        {
            _car.CarBodyType = BodyType.HatchBack;
        }

        public void BuildEngine()
        {
            _car.CarEngineType = EngineType.Petrol;
        }

        public void BuildSeats()
        {
            _car.CarSeatType = SeatType.Regular;
        }

        public Car MyCar
        {
            get { return _car; }
        }

    }
}
