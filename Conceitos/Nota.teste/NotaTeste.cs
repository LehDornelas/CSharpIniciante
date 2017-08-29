using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nota;

namespace Nota.teste
{
    [TestClass]
    public class NotaTeste
    {
        [TestMethod]
        public void MaiorNota()
        {
            CadernoNota caderno = new CadernoNota();
            caderno.AddNota(10);
            caderno.AddNota(5);
            caderno.AddNota(6);

            Estatistica resultado = caderno.CalcularEstatistica();

            Assert.AreEqual(10, resultado.HighestGrade);
        }

        [TestMethod]
        public void MenorNota()
        {
            CadernoNota caderno = new CadernoNota();
            caderno.AddNota(10);
            caderno.AddNota(5);
            caderno.AddNota(8.5f);

            Estatistica resultado = caderno.CalcularEstatistica();

            Assert.AreEqual(5, resultado.LowestGrade);
        }

        [TestMethod]
        public void MediaNota()
        {
            CadernoNota caderno = new CadernoNota();
            caderno.AddNota(10);
            caderno.AddNota(10);
            caderno.AddNota(10);

            Estatistica resultado = caderno.CalcularEstatistica();

            Assert.AreEqual(10, resultado.AvarageGrade);
        }

    }
}
