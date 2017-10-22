using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota
{
    public class ThrowAwayGradeBook : CadernoNota
    {
        public override Estatistica CalcularEstatistica()
        {
            Console.WriteLine("ThrowAwayGradeBook : ComputeStatistics");

            float lowest = float.MaxValue;
            foreach (float grade in notas)
            {
                lowest = Math.Min(grade,lowest);
            }

            notas.Remove(lowest);

            return base.CalcularEstatistica();
        }
    }
}
