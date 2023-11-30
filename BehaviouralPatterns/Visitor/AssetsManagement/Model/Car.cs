namespace AssetsManagement.Model
{
    public class Car : Asset
    {
        public long Price { get; set; }
        public long MonthlyCost { get; set; }
        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}