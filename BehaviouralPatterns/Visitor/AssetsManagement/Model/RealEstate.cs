namespace AssetsManagement.Model
{
    public class RealEstate : Asset
    {
        public long Price { get; set; }
        public long MonthlyCost { get; set; }
        public long MonthlyRentIncome { get; set; }

        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}