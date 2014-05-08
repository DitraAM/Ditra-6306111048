using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace UnitTestKalkulator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainWindow main = new MainWindow();
            double result = main.tambah(2, 2);
            double expect = 4;
            Assert.AreEqual(expect, result, "Penjumlahan salah");

        }

        [TestMethod]
        public void TestMethod2()
        {
            MainWindow main = new MainWindow();
            double result = main.kurang(7, 2);
            double expect = 5;
            Assert.AreEqual(expect, result, "Pengurangan salah");

        }

        [TestMethod]
        public void TestMethod3()
        {
            MainWindow main = new MainWindow();
            double result = main.kali(7, 2);
            double expect = 14;
            Assert.AreEqual(expect, result, "Perkalian salah");

        }

        [TestMethod]
        public void TestMethod4()
        {
            MainWindow main = new MainWindow();
            double result = main.bagi(6, 2);
            double expect = 3;
            Assert.AreEqual(expect, result, "Pembagian salah");

        }

    }
}
