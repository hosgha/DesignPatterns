using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetsManagement.Model;

namespace AssetsManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = new ProcessStartInfo()
            {
                WindowStyle = ProcessWindowStyle.Maximized
            };

            #region Visitor
            //var bankAccount = new BankAccount() {Balance = 100, Loan = 50, MonthlyProfit = 2};
            //var car = new Car() { MonthlyCost = 1, Price = 20};
            //var realEstate = new RealEstate() {Price = 2000, MonthlyRentIncome = 100, MonthlyCost = 20};
            //var person = new Person(bankAccount, car, realEstate);

            //var netWorthVisitor = new NetWorthVisitor();
            //var monthlyVisitor = new MonthlyIncomeVisitor();

            //person.AcceptAssetVisitor(netWorthVisitor);
            //person.AcceptAssetVisitor(monthlyVisitor);

            //Console.WriteLine("MonthlyIncome : " + monthlyVisitor.GetMonthlyIncome());
            //Console.WriteLine("NetWorth : " + netWorthVisitor.GetNetWorth());
            #endregion

            Console.ReadLine();
        }
    }
}
