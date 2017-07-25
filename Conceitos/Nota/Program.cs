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

            caderno.AddNota(1);
            caderno.AddNota(2.3f);
        }
    }//
}
