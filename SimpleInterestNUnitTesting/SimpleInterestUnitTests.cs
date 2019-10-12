using NUnit.Framework;
using SimpleInterest.Composite;
using SimpleInterest.Leaf;

namespace SimpleInterestNUnitTesting
{
    public class SimpleInterestUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CardTest()
        {
            Card mc = new Card("MC", .05, 100);
            double result = mc.CalculateInterest();
            double expectedValue = 5;
            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        public void WalletTest()
        {
            Card mc = new Card("MC", .05, 100);
            Card vs = new Card("VISA", .10, 100);
            Card dis = new Card("DIS", .01, 100);

            Wallet wallet = new Wallet() { cards = { mc, vs, dis } };
            double result = wallet.CalculateInterest();
            double expectedValue = 16;
            Assert.AreEqual(expectedValue, result);

        }

        [Test]
        public void OneCardHolderOneWalletThreeCardsTest()
        {
            double result;
            double expectedValue;

            Card mc = new Card("MC", .05, 100);
            Card vs = new Card("VISA", .10, 100);
            Card dis = new Card("DIS", .01, 100);

            result = mc.CalculateInterest();
            expectedValue = 5;
            Assert.AreEqual(expectedValue, result);

            result = vs.CalculateInterest();
            expectedValue = 10;
            Assert.AreEqual(expectedValue, result);

            result = dis.CalculateInterest();
            expectedValue = 1;
            Assert.AreEqual(expectedValue, result);


            Wallet wallet = new Wallet() { cards = { mc, vs, dis } };
            CardHolder cardHolder = new CardHolder() { wallets = { wallet } };
            result = cardHolder.CalculateInterest();
            expectedValue = 16;
            Assert.AreEqual(expectedValue, result);

        }

        [Test]
        public void OneCardHolderTwoWalletsTest()
        {
            double result;
            double expectedValue;

            Card vs = new Card("VISA", .10, 100);
            Card dis = new Card("DIS", .01, 100);
            Wallet wallet = new Wallet() { cards = { vs, dis } };
            result = wallet.CalculateInterest();
            expectedValue = 11;
            Assert.AreEqual(expectedValue, result);

            Card mc2 = new Card("MC", .05, 100);
            Wallet wallet2 = new Wallet() { cards = { mc2 } };
            result = wallet2.CalculateInterest();
            expectedValue = 5;
            Assert.AreEqual(expectedValue, result);


            CardHolder cardHolder = new CardHolder() { wallets = { wallet, wallet2 } };
            result = cardHolder.CalculateInterest();
            expectedValue = 16;
            Assert.AreEqual(expectedValue, result);

        }

        [Test]
        public void TwoCardHolderOneWalletEachTest()
        {
            double result;
            double expectedValue;

            Card mc = new Card("MC", .05, 100);
            Card vs = new Card("VISA", .10, 100);
            Card dis = new Card("DIS", .01, 100);
            Wallet wallet = new Wallet() { cards = { mc, vs, dis } };

            CardHolder cardHolder = new CardHolder() { wallets = { wallet } };
            result = cardHolder.CalculateInterest();
            expectedValue = 16;
            Assert.AreEqual(expectedValue, result);


            Card mc2 = new Card("MC", .05, 100);
            Card vs2 = new Card("VISA", .10, 100);
            Wallet wallet2 = new Wallet() { cards = { mc2, vs2 } };
            CardHolder cardHolder2 = new CardHolder() { wallets = { wallet2 } };
            result = cardHolder2.CalculateInterest();
            expectedValue = 15;
            Assert.AreEqual(expectedValue, result);



        }
    }
}