using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota.teste.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void VariablesHoldReference() {

            CadernoNota c1 = new CadernoNota();
            CadernoNota c2 = c1;

            c1.Nome = "LSS";
            Console.WriteLine(c2.Nome);
            Assert.AreEqual(c1.Nome, c2.Nome);
        }
    }
}
