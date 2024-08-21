using AulasPOO.uteis;

namespace TestProject1
{
    [TestClass]
    public class CalculadoraTest
    {

        [TestMethod]
        public void SomaTest()
        {
            //Cenário
            var calc = new Calculadora();
            int num1 = 22;
            int num2 = 20;
            int res;
            //Ação
            res = calc.Soma(num1, num2);
            //Teste
            Assert.AreEqual(42, res);
        }

        [TestMethod]
        public void MultTest()
        {
            int num1 = 20;
            int num2 = 3;
            int res;
            res = Calculadora.Mult(num1, num2);
            Assert.AreEqual(60, res);

        }

        [TestMethod]
        public void ImcTest()
        {
            double peso = 87.5;
            double alt = 1.8;
            double imc;
            imc = Calculadora.IMC(peso, alt);
            Assert.AreEqual(27.01, Math.Round(imc, 2));
        }
    }
}