using NUnit.Framework;
using System;

namespace Kaizenko.Vending.Tests
{
    public class VendingMachineTests
    {
        VendingMachine vendingMachine;

        [SetUp]
        public void setup()
        {
            vendingMachine = new VendingMachine();
        }

        [Test]
        public void ReleaseChange_WhenNoMoney_ExpectNoChange()
        {
            //arrange
           
            //act
            int change = vendingMachine.ReleaseChange();
            //assert
            Assert.That(change, Is.EqualTo(0));
        }

        [Test]
        public void ReleaseChange_When25cInserted_Expect25c()
        {
            //arrange
           
            vendingMachine.InsertCoin();
            //act
            int change = vendingMachine.ReleaseChange();
            //assert
            Assert.That(change, Is.EqualTo(25));
        }

        [Test]
        public void ReleaseChange_When50cInserted_Expect50c()
        {
            //arrange
           
            vendingMachine.InsertCoin();
            vendingMachine.InsertCoin();
            //act
            int change = vendingMachine.ReleaseChange();
            //assert
            Assert.That(change, Is.EqualTo(50));
        }

        [Test]
        public void BuyProduct_WhenNoInserted_ExpectNoProduct()
        {
          
            Product product = vendingMachine.BuyProduct();
            Assert.That(product, Is.Null);
        }

        [Test]
        public void BuyProduct_When25cInserted_ExpectNoProduct()
        {
           
            vendingMachine.InsertCoin();
            Product product = vendingMachine.BuyProduct();
            Assert.That(product, Is.Null);
        }

        [Test]
        public void BuyProduct_When50cInserted_ExpectProduct()
        {
            //arrange
            
            vendingMachine.InsertCoin();
            vendingMachine.InsertCoin();
            //act
            Product product = vendingMachine.BuyProduct();
            Assert.That(product, Is.Not.Null);
        }

        [Test]
        public void BuyProduct_When75cInserted_ExpectProduct()
        {
            //arrange
          
            vendingMachine.InsertCoin();
            vendingMachine.InsertCoin();
            vendingMachine.InsertCoin();
            //act
            Product product = vendingMachine.BuyProduct();
            Assert.That(product, Is.Not.Null);
        }

        [Test]
        public void ReleaseChange_WhenProudctPurchasedWith75c_Expect25c()
        {
            //arrange
           
            vendingMachine.InsertCoin();
            vendingMachine.InsertCoin();
            vendingMachine.InsertCoin();
            vendingMachine.BuyProduct();
            //act
            int change = vendingMachine.ReleaseChange();
            //assert
            Assert.That(change, Is.EqualTo(25));
        }

        [Test]
        public void ReleaseChange_WhenReleasedTwiceWith25c_Expect0c()
        {
        
            vendingMachine.InsertCoin();
            vendingMachine.ReleaseChange();
            int change = vendingMachine.ReleaseChange();
            Assert.That(change, Is.EqualTo(0));
        }

      
    }
}
