using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddHw2;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            List<Book> first= new List<Book>{
                    new Book {name =  "Harry Potter1", Cost= 100, count = 1}
                };
            //int[] first = new int[] { 1, 0, 0, 0, 0 };
            int expected = 100;
            int actual = target.calculateFee(first);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void buyFirst_1_Second_1()
        {
            PotterShoppingCart target = new PotterShoppingCart();
            List<Book> first = new List<Book>{
                    new Book {name =  "Harry Potter1", Cost= 100, count = 1},
                    new Book {name =  "Harry Potter2", Cost= 100, count = 1}
                };
            int expected = 190;
            int actual = target.calculateFee(first);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void buyFirst_1_Second_1_Third_1()
        {
            PotterShoppingCart target = new PotterShoppingCart();
            List<Book> first = new List<Book>{
                    new Book {name =  "Harry Potter1", Cost= 100, count = 1},
                    new Book {name =  "Harry Potter2", Cost= 100, count = 1},
                    new Book {name =  "Harry Potter3", Cost= 100, count = 1}
                };
            int expected = 270;
            int actual = target.calculateFee(first);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void buyFirst_1_Second_1_Third_1_Fourth_1()
        {
            PotterShoppingCart target = new PotterShoppingCart();
            List<Book> first = new List<Book>{
                    new Book {name =  "Harry Potter1", Cost= 100, count = 1}
                };
            int expected = 320;
            int actual = target.calculateFee(first);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void buyFirst_1_Second_1_Third_1_Fourth_1_Five_1()
        {
            PotterShoppingCart target = new PotterShoppingCart();
            List<Book> first = new List<Book>{
                    new Book {name =  "Harry Potter1", Cost= 100, count = 1}
                };
            int expected = 375;
            int actual = target.calculateFee(first);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void buyFirst_1_Second_1_Third_2()
        {
            PotterShoppingCart target = new PotterShoppingCart();
            List<Book> first = new List<Book>{
                    new Book {name =  "Harry Potter1", Cost= 100, count = 1}
                };
            int expected = 370;
            int actual = target.calculateFee(first);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void buyFirst_1_Second_2_Third_2()
        {
            PotterShoppingCart target = new PotterShoppingCart();
            List<Book> first = new List<Book>{
                    new Book {name =  "Harry Potter1", Cost= 100, count = 1}
                };
            int expected = 460;
            int actual = target.calculateFee(first);
            Assert.AreEqual(expected, actual);
        }
    }
}