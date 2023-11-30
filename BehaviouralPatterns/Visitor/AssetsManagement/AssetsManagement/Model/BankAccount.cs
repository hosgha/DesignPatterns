namespace AssetsManagement.Model
{
    public class BankAccount : Asset
    {
        public long Balance { get; set; }
        public long MonthlyProfit { get; set; }
        public long Loan { get; set; }
        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}