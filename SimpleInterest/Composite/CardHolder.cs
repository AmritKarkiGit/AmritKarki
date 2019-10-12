using SimpleInterest.Component;
using System.Collections.Generic;

namespace SimpleInterest.Composite
{
    public class CardHolder : InterestCalculation
    {

        public List<InterestCalculation> wallets;
        public CardHolder()
        {

            wallets = new List<InterestCalculation>();


        }


        public override double CalculateInterest()
        {
            double total = 0;

            foreach (var wallet in wallets)
            {
                total += wallet.CalculateInterest();

            }
            return total;
        }

    }
}
