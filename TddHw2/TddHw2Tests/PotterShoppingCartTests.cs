using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddHw2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddHw2.Tests
{
    [TestClass()]
    public class PotterShoppingCartTests
    {
        [TestMethod()]
        public void buyFirst_1()
        {
            PotterShoppingCart target = new PotterShoppingCart();
            int[] first = new int[] { 1, 0, 0, 0, 0 };
            int expected = 100;
            int actual = target.calculateFee();
            Assert.AreEqual(expected, actual);

        }
    }
}