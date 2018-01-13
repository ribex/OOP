namespace Composition
{
    public class Cash
    {
        public double CashBalance { get; set; }

        public Cash()
        {
                
        }

        public Cash(double amount)
        {
            CashBalance = amount;
        }
    }
}