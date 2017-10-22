using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota
{
    internal interface IGradeTracker
    {
        void AddNota(float grade);
        Estatistica CalcularEstatistica();
        void WriteGrades(TextWriter destination);
        string Nome { get; set; }
    }
}
