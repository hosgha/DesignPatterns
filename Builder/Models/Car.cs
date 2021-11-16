using Builder.Enums;

namespace Builder.Models
{
    // Product
    public class Car
    {
        private string _carName;

        public Car(string carName)
        {
            _carName = carName;
        }

        public BodyType CarBodyType { get; set; }
        public EngineType CarEngineType { get; set; }
        public SeatType CarSeatType { get; set; }

        public string CarName
        {
            get { return _carName; }
        }

        public string GetDetails()
        {
            return string.Format("Name: {0}\nBodyType: {1}\nEngineType: {2}\nSeatType: {3}", CarName, CarBodyType, CarEngineType, CarSeatType);
        }

    }
}
