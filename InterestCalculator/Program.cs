using SimpleInterest.Component;
using SimpleInterest.Composite;
using SimpleInterest.Leaf;
using System;

namespace InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {


            Card mc = new Card("MS", .05, 100);
            Card vs = new Card("VS", .10, 100);
            Card dis = new Card("DIS", .01, 100);
            Card amx = new Card("AMX", .03, 100);


            Wallet wallet1 = new Wallet() { cards = { mc, vs, dis } };
            Console.WriteLine("The total interest wallet 1 is {0} ", wallet1.CalculateInterest());

            Card mc1 = new Card("MS", .05, 100);
            Card dis1 = new Card("DIS", .01, 100);

            Wallet wallet2 = new Wallet() { cards = { mc1, dis1 } };
            Console.WriteLine("The total interest wallet 2 is {0} ", wallet2.CalculateInterest());


            CardHolder cardHolder1 = new CardHolder() { wallets = { wallet1, wallet2 } };

            Console.WriteLine("The total interest ot mutiplewallets is {0} ", cardHolder1.CalculateInterest());

            CardHolder cardHolder2 = new CardHolder() { wallets = { wallet2 } };
            CardHolder cardHolder3 = new CardHolder() { wallets = { wallet1 } };


            Account account = new Account() { cardHolders = { cardHolder2, cardHolder3 } };

            Console.WriteLine("The total interest ot mutiplewallets is {0} ", account.CalculateInterest());


        }
    }
}
