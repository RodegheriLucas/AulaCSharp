using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulasPOO.uteis;

namespace TestProject1
{
    [TestClass]
    public class SorteadorTeste
    {
        [TestMethod]
        public void Sorteador()
        {
            List<string> list = new List<string>();
            list = ["joão", "maria", "josé", "antonio"];
            var Gen = new Sorteador();
            var Sorteados = Gen.Sorter(list);
            string final2 = string.Join(", ", Sorteados);
            string final1 = string.Join(", ", list);
            Assert.AreNotEqual(final1, final2);
            return;
        }
    }
}
