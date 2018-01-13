using System;
using System.Security.Cryptography.X509Certificates;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCash = new Cash(121.36);
            var myStocks = new Stocks(2342.87);
            var myBonds = new Bonds(3212.03);
            var myMutualFunds = new MutualFunds(4321.45);
            var myPortfolio = new Portfolio();
            Console.WriteLine("Total Portfolio Balance: " + myPortfolio.TotalBalance(myCash.CashBalance, myStocks.StocksBalance, myBonds.BondsBalance, myMutualFunds.MutualFundsBalance));
        }
    }

    public class Portfolio
    {
        public Cash cash;
        public Stocks stocks;
        public Bonds bonds;
        public MutualFunds mutualFunds;

        public Portfolio() { }

        public Portfolio(double cash, double stocks, double bonds, double mutualFunds)
        {
            this.cash = new Cash(cash);
            this.stocks = new Stocks(stocks);
            this.bonds = new Bonds(bonds);
            this.mutualFunds = new MutualFunds(mutualFunds);
        }

        public double TotalBalance(double cash, double stocks, double bonds, double mutualFunds)
        {
            return cash + stocks + bonds + mutualFunds;
        }

    }
}



