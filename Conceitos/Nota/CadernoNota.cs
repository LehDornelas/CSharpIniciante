using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota
{
    //internal - Apenas o mesmo assembly (padrao)
    //private - Apenas a mesma classe
    //public - Todas
    public class CadernoNota
    {
        List<float> notas;
        //ctor - criação de um construtor
        public CadernoNota()
        {
            notas = new List<float>();
        }

        public  Estatistica CalcularEstatistica()
        {
            Estatistica estatis = new Estatistica();

            float sum = 0;
            foreach (float grade in notas)
            {
                estatis.HighestGrade = Math.Max(grade, estatis.HighestGrade);
                estatis.LowestGrade = Math.Min(grade, estatis.LowestGrade);
                sum = sum + grade; //sum += grade;
            }

            estatis.AvarageGrade = sum / notas.Count;
            return estatis;
        }

        public string Nome;
        public void AddNota(float nota)
        {
            notas.Add(nota);
        }
    }
}
