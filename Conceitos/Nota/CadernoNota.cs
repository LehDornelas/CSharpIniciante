using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota
{
    class CadernoNota
    {
        //ctor - criação de um construtor
        public CadernoNota()
        {

        }

        List<float> notas = new List<float>();
        public void AddNota(float nota)
        {
            notas.Add(nota);
        }
    }
}
