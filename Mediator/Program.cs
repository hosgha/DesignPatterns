
FacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();

User Ram = new ConcreteUser(facebookMediator, "Ram");
User Dave = new ConcreteUser(facebookMediator, "Dave");
User Smith = new ConcreteUser(facebookMediator, "Smith");
User Rajesh = new ConcreteUser(facebookMediator, "Rajesh");
User Sam = new ConcreteUser(facebookMediator, "Sam");

facebookMediator.RegisterUser(Ram);
facebookMediator.RegisterUser(Dave);
facebookMediator.RegisterUser(Smith);
facebookMediator.RegisterUser(Rajesh);
facebookMediator.RegisterUser(Sam);

Dave.Send("dotnettutorials.net - this website is very good to learn Design Pattern");

Console.Write("\n\n\n");

Rajesh.Send("What is Design Patterns? Please explain ");

Console.Read();
