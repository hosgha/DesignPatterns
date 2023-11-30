namespace AssetsManagement.Model
{
    public class NetWorthVisitor : IVisitor
    {
        private long _networth = 0;
        public void Visit(BankAccount bankAccount)
        {
            _networth += bankAccount.Balance;
            _networth -= bankAccount.Loan;
        }

        public void Visit(Car car)
        {
            _networth += car.Price;
        }

        public void Visit(RealEstate estate)
        {
            _networth += estate.Price;
        }

        public long GetNetWorth()
        {
            return _networth;
        }
    }
}