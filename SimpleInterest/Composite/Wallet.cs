using SimpleInterest.Component;
using System.Collections.Generic;


namespace SimpleInterest.Composite
{
    public class Wallet : InterestCalculation
    {
        public List<InterestCalculation> cards;
        public Wallet()
        {

            cards = new List<InterestCalculation>();


        }


        public override double CalculateInterest()
        {
            double total = 0;

            foreach (var card in cards)
            {
                total += card.CalculateInterest();

            }
            return total;
        }
    }
}