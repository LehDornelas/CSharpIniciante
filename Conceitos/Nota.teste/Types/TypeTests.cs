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
        public void IntTipoPassandoPorParametro()
        {
            int x = 46;
            Assert.AreEqual(46,x);

        }

        private void IncrementarUmNumero(int num)
        {
            num += 1;
        }

        [TestMethod]
        public void TiposDeReferenciaPassandoPorValor()
        {
            CadernoNota c1 = new CadernoNota();
            CadernoNota c2 = c1;

            DarumNomeCaderno(c2);

            Assert.AreEqual("Livro1", c1.Nome);

        }

        [TestMethod]
        public void TiposDeReferenciaPassandoPorValor2()
        {
            CadernoNota c1 = new CadernoNota();
            CadernoNota c2 = c1;

            DarumNomeCaderno2(ref c2);

            Assert.AreEqual("Livro1", c2.Nome);

        }


        private void DarumNomeCaderno(CadernoNota caderno)
        {
            caderno.Nome = "Livro1";
        }
        private void DarumNomeCaderno2(ref CadernoNota caderno)
        {
            caderno = new CadernoNota();
            caderno.Nome = "Livro1";
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015,1,1);
            //date.AddDays(1); - Erro

            date = date.AddDays(1);

            Assert.AreEqual(2,date.Day);

        }
        [TestMethod]
        public void UpperCaseString()
        {
            string nome = "teste";
            //nome.ToUpper(); - Erro

            nome = nome.ToUpper();

            Assert.AreEqual("TESTE", nome);

        }

        [TestMethod]
        public void UssingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f,grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            //grades = new float[5]; - Erro
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void VariablesHoldReference() {

            CadernoNota c1 = new CadernoNota();
            CadernoNota c2 = c1;

            c1.Nome = "LSS";
            Console.WriteLine(c2.Nome);
            Assert.AreEqual(c1.Nome, c2.Nome);
        }

        [TestMethod]
        public void intVariablesHoldReference()
        {

            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1,x2);
        }

        [TestMethod]
        public void ObjectVariablesHoldReference()
        {

            CadernoNota c1 = new CadernoNota();
            CadernoNota c2 = c1;

            c1 = new CadernoNota();

            c1.Nome = "LSS";
            Console.WriteLine(c2.Nome);
            Assert.AreNotEqual(c1.Nome, c2.Nome);
        }

        [TestMethod]
        public void ComparacaodeString()
        {

            string n1 = "Leticia";
            string n2 = "leticia";

            bool result = string.Equals(n1,n2,StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);

        }

    }
}
