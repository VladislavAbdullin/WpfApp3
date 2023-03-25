using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfApp3.Classes;
using System.Windows;
using WpfApp3.Windows;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Sale ras = new Sale(Convert.ToDecimal(46.90), Convert.ToDecimal(12.90), Convert.ToDecimal(53.5));
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                string деньги = "0,2548";

                if (деньги == "")
                {
                    throw new AssertFailedException("Внесите сумму");
                }

                decimal price = ras.Расчет(true, true, false);

                decimal money;

                try
                {
                    money = Convert.ToDecimal(деньги);
                }
                catch (Exception)
                {
                    throw new AssertFailedException("Введите правмльно сумму");
                }

                if (money < price)
                {
                    throw new AssertFailedException("Денег не хватает");
                }
            }
            catch (AssertFailedException exception)
            {
                if (exception.Message != "Денег не хватает")
                {
                    throw new AssertFailedException();
                }
            }
        }
        [TestMethod]
        public void TestMethod2()
        {

        }
        [TestMethod]
        public void TestMethod3()
        {

        }
    }
}
