using System;

namespace AssetsManagement.Model
{
    public class MonthlyIncomeVisitor : IVisitor
    {
        private long _monthlyIncome = 0;
        public void Visit(BankAccount bankAccount)
        {
            _monthlyIncome += bankAccount.MonthlyProfit;
        }

        public void Visit(Car car)
        {
            _monthlyIncome -= car.MonthlyCost;
        }

        public void Visit(RealEstate estate)
        {
            _monthlyIncome -= estate.MonthlyCost;
            _monthlyIncome += estate.MonthlyRentIncome;
        }

        public long GetMonthlyIncome()
        {
            return _monthlyIncome;
        }
    }
}