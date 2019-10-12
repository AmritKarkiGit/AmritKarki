using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInterest.Component;

namespace SimpleInterest.Composite
{
    public class Account: InterestCalculation
    {
        public List<InterestCalculation> cardHolders ;
        public Account()
        {
            cardHolders = new List<InterestCalculation>();

        }
        public override double CalculateInterest()
        {
            double total = 0;

            foreach (var cardHolder in cardHolders)
            {
                total += cardHolder.CalculateInterest();

            }
            return total;
        }

    }
}
