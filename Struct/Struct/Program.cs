using System;
using System.Collections;
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

            Livro livro2;
            livro2.codigo = 2;
            livro2.nomeAutor = "Teste2";
            livro2.titulo = "Livro do teste2";

            ArrayList livros = new ArrayList();
            livros.Add(livro1);
            livros.Add(livro2);

            foreach (Livro l in livros)
            {
                Console.WriteLine("Codigo:" + l.codigo.ToString());
                Console.WriteLine("Codigo:" + l.nomeAutor);
            }
            Console.ReadKey();
        }
    }
}
