namespace Builder.Models
{
    // Director 
    public class CarManufacturer
    {
        public void BuildCar(ICarBuilder carBuilder)
        {
            carBuilder.BuildBody();
            carBuilder.BuildEngine();
            carBuilder.BuildSeats();
        }
    }
}
