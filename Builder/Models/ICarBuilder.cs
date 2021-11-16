namespace Builder.Models
{
    // Builder
    public interface ICarBuilder
    {
        void BuildBody();
        void BuildEngine();
        void BuildSeats();

        Car MyCar { get; }
    }
}
