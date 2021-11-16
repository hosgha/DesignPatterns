using Prototype;
using System.Text.Json;

var investors = InvestorMock.GetInvestors().ToList();

var userPrototype = new User
{
    Id = Guid.NewGuid(),
    AccessFailedCount = 0,
    Email = "test@hgh.com",
    EmailConfirmed = true,
    IsAcive = true,
    Person = new Person
    {
        FirstName = string.Empty,
        LastName = string.Empty,
        NationalCode = string.Empty
    },
    LockoutEnable = false,
    LockoutEnd = true,
    PhoneNumberConfirmed = true,
    UserName = string.Empty
};

var users = new List<User>();

foreach (var investor in investors)
{
    var user = (User)userPrototype.Clone(investor);      
    users.Add(user);
}

Console.WriteLine(JsonSerializer.Serialize(users));