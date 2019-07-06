using System;
using AccountConsoleApp;
using AccountItem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AccountConsoleApp_Tests
{
    [TestClass]
    public class Accounts_Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AccountsAccessorFailsIfNoItemIncluded()
        {
            Accounts ac = new Accounts();
            Item it = ac[0];
        }

        [TestMethod]
        public void AccountsAccessorGetRightItem()
        {
            Accounts ac = new Accounts();
            Item it = new Item("TestItem", Category.Income, 0);
            ac.AddItem(it);
            Assert.AreEqual(it, ac[0]);
        }

        [TestMethod]
        public void AccountsAccessorSetRightItem()
        {
            Accounts ac = new Accounts();
            Item it = new Item("TestItem", Category.Income, 0);
            ac.AddItem(it);
            Item newItem = new Item("NewTestItem", Category.Spending, 10);
            ac[0] = newItem;
            Assert.AreEqual(newItem, ac[0]);
        }

        [TestMethod]
        public void RemoveItemMethodRemoveTheRightItem()
        {
            Accounts ac = new Accounts();
            Item it1 = new Item("TestItem1", Category.Income, 20);
            Item it2 = new Item("TestItem2", Category.Spending, 10);
            Item it3 = new Item("TestItem3", Category.Income, 10);
            ac.AddItem(it1);
            ac.AddItem(it2);
            ac.AddItem(it3);
            Assert.AreEqual(it2, ac[1]);
            ac.RemoveItem(it2);
            Assert.AreEqual(it3, ac[1]);
            Assert.AreEqual(it1, ac[0]);
        }

        [TestMethod]
        public void TotalRevenueTest()
        {
            Accounts ac = new Accounts();
            Item it1 = new Item("TestItem1", Category.Income, 20, Currency.EUR);
            Item it2 = new Item("TestItem2", Category.Spending, 10, Currency.USD);
            Item it3 = new Item("TestItem3", Category.Income, 15, new DateTime(2019, 05, 16));
            ac.AddItem(it1);
            ac.AddItem(it2);
            ac.AddItem(it3);

            Money actual = ac.TotalRevenue(DateTime.Now);
            Money expected = new Money( 20 * Money.CurrencyEUR - 10 * Money.CurrencyUSD );
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(expected.currency, actual.currency);
        }
    }
}
