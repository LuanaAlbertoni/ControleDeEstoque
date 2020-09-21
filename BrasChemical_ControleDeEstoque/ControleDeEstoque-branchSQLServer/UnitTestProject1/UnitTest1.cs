using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControleDeEstoque.Web.Helpers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string entrada = "BC16-0001";
            string saida = "BC16-0002";
            Assert.AreEqual(saida, Helper.GetNextLote(entrada));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string entrada = "BC16-1022";
            string saida = "BC16-1023";

            Assert.AreEqual(saida, Helper.GetNextLote(entrada));
        }

        [TestMethod]
        public void TestMethod3()
        {
            string entrada = "BC14-0001";
            string saida = "BC16-0001";

            Assert.AreEqual(saida, Helper.GetNextLote(entrada));
        }


        [TestMethod]
        public void TestMethod4()
        {
            string entrada = "BC14-0101";
            string saida = "BC16-0001";

            Assert.AreEqual(saida, Helper.GetNextLote(entrada));
        }

        [TestMethod]
        public void TestMethod5()
        {
            string entrada = "BC16-0101";
            string saida = "BC16-0102";

            Assert.AreEqual(saida, Helper.GetNextLote(entrada));
        }

    }
}
