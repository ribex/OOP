namespace Composition
{
    public class Stocks
    {
        public double StocksBalance { get; set; }

        public Stocks()
        {
                
        }

        public Stocks(double amount)
        {
            var balance = amount;
        }
    }
}