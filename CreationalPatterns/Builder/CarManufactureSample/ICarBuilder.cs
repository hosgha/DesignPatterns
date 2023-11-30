namespace Builder;

// Builder
public interface ICarBuilder
{
    void BuildBody();
    void BuildEngine();
    void BuildSeats();

    Car MyCar { get; }
}
