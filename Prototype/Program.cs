using Newtonsoft.Json;
using Prototype;

var investors = InvestorMock.GetInvestors().ToList();

var userPrototype = User.GenerateInvestorProtoypeUser();

var users = new List<User>();

foreach (var investor in investors)
{
    var user = (User)userPrototype.Clone(investor);      
    users.Add(user);
}

Console.WriteLine(JsonConvert.SerializeObject(users, Formatting.Indented));