namespace Prototype
{
    public class User : IUser
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool LockoutEnd { get; set; }
        public bool LockoutEnable { get; set; }
        public int AccessFailedCount { get; set; }
        public bool IsAcive { get; set; }
        public int ReferralCode { get; set; }
        public Person Person { get; set; }

        public IUser Clone(Investor investor)
        {
            var user = (User)this.MemberwiseClone();
            user.Id = Guid.NewGuid();
            user.UserName = investor.NationalCode;
            user.Person = investor;
            user.ReferralCode = investor.ReferralCode;
            return user;
        }
    }
}
