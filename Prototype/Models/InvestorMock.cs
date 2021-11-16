namespace Prototype
{
    public static class InvestorMock
    {       
        public static IEnumerable<Investor> GetInvestors()
        {
            return new List<Investor>
            {
                new Investor("Fronk", "Jordan", "543454664", 1001),
                new Investor("Brayan", "Taylor", "542334664", 1002),
                new Investor("Robert", "Muller", "003454664", 1003),
                new Investor("Sarah","Jordan","013454664", 1004),
                new Investor("Suzan", "Pitt","009954664", 1005)
            };
        }
    }

    public class Investor : Person
    {
        public Investor(string firstName, string lastName, string nationalCode, int referralCode)
        {
            FirstName = firstName;
            LastName = lastName;
            NationalCode = nationalCode;
            ReferralCode = referralCode;
        }

        public int ReferralCode { get; set; }
    }
}
