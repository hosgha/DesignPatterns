using Builder;

// Director
CarManufacturer carMfg = new CarManufacturer();

// Builder
ICarBuilder carBuilder1;
////Build Maruti Car 
carBuilder1 = new MarutiCarBuilder();
carMfg.BuildCar(carBuilder1);
Console.WriteLine(">>>>>> Built Car Specs are:\n{0}", carBuilder1.MyCar.GetDetails());

// Builder
ICarBuilder carBuilder2;
////Build Skoda car 
carBuilder2 = new SkodaCarBuilder();
carMfg.BuildCar(carBuilder2);
Console.WriteLine("\n\n>>>>>> Built Car Specs are:\n{0}", carBuilder2.MyCar.GetDetails());