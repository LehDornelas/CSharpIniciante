using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            CadernoNota caderno = new CadernoNota();

            caderno.AddNota(91);
            caderno.AddNota(89.5f);
            caderno.AddNota(75);

            Estatistica estatis = caderno.CalcularEstatistica();
            Console.WriteLine(estatis.AvarageGrade);
            Console.WriteLine(estatis.HighestGrade);
            Console.WriteLine(estatis.LowestGrade);
            Console.ReadKey();
        }
    }
}
