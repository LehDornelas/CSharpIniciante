using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota
{
    public class Estatistica
    {
        public Estatistica()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public float AvarageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
