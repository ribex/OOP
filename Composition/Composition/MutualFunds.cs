namespace Composition
{
    public class MutualFunds
    {
        public double MutualFundsBalance { get; set; }

        public MutualFunds()
        {
                
        }

        public MutualFunds(double amount)
        {
            var balance = amount;
        }
    }
}