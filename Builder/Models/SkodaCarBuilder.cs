using Builder.Enums;

namespace Builder.Models
{
    // Concreate Builder
    public class SkodaCarBuilder : ICarBuilder
    {
        private Car _car;

        public SkodaCarBuilder()
        {
            _car = new Car("Skoda");
        }

        public void BuildBody()
        {
            _car.CarBodyType = BodyType.Sedan;
        }

        public void BuildEngine()
        {
            _car.CarEngineType = EngineType.Diesal;
        }

        public void BuildSeats()
        {
            _car.CarSeatType = SeatType.SemiSleeper;
        }

        public Car MyCar
        {
            get { return _car; }

        }

    }
}
