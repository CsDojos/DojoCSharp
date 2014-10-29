using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectRomanos
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_1_To_I()
        {
            var resultado = "I";
            var romanos = new Romanos();
            var numero = 1;
            Assert.AreEqual(resultado, romanos.Convert(numero));
        }

        [TestMethod]
        public void Test_2_To_II()
        {
            var resultado = "II";
            var romanos = new Romanos();
            var numero = 2;
            Assert.AreEqual(resultado, romanos.Convert(numero));
        }

        [TestMethod]
        public void Test_3_To_III()
        {
            var resultado = "III";
            var romanos = new Romanos();
            var numero = 3;
            Assert.AreEqual(resultado, romanos.Convert(numero));
        }

        [TestMethod]
        public void Test_4_To_IV()
        {
            var resultado = "IV";
            var romanos = new Romanos();
            var numero = 4;
            Assert.AreEqual(resultado, romanos.Convert(numero));
        }
        [TestMethod]
        public void Test_5_To_V()
        {
            var resultado = "V";
            var romanos = new Romanos();
            var numero = 5;
            Assert.AreEqual(resultado, romanos.Convert(numero));
        }
        [TestMethod]
        public void Test_6_To_VI()
        {
            var resultado = "VI";
            var romanos = new Romanos();
            var numero = 6;
            Assert.AreEqual(resultado, romanos.Convert(numero));
        }
        public void Test_9_To_IX()
        {
            var resultado = "IX";
            var romanos = new Romanos();
            var numero = 9;
            Assert.AreEqual(resultado, romanos.Convert(numero));
        }
    }
}
