using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {

        public struct Livro
        {
            public int codigo;
            public string nomeAutor;
            public string titulo;
        }
        static void Main(string[] args)
        {
            Livro livro1;
            livro1.codigo = 1;
            livro1.nomeAutor = "Teste";
            livro1.titulo = "Livro do teste";
        }
    }
}
