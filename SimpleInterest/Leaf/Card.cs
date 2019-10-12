using SimpleInterest.Component;

namespace SimpleInterest.Leaf
{
    public class Card : InterestCalculation
    {
        protected string brandName;
        protected double interest;
        protected double balance;
        public Card(string brandName, double interest, double balance)
        {
            this.brandName = brandName;
            this.interest = interest;
            this.balance = balance;
        }
        public override double CalculateInterest()
        {
            return balance * interest;

        }
    }
}
