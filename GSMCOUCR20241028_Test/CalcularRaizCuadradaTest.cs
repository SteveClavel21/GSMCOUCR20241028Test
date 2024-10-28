using GSMCOUCR20241028Test;

namespace GSMCOUCR20241028_Test
{
    [TestClass]
    public class CalcularRaizCuadradaTest
    {
        [TestMethod]
        public void CalcularRaizCuadradamethod()
        {
            CalcularRaizCuadradaclass calcularRaiz = new();

            Assert.AreEqual(5, calcularRaiz.CalcularRaizCuadrada(25));
        }

        [TestMethod]
        public void raizCero()
        {
            CalcularRaizCuadradaclass calcular = new();

            Assert.AreEqual(0, calcular.CalcularRaizCuadrada(0));
        }

        [TestMethod]
        public void Negativos()
        {
            CalcularRaizCuadradaclass calcular = new();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calcular.CalcularRaizCuadrada(-9));
        }
    }
}