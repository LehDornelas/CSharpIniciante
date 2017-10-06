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

            caderno.NameChanged += new NameChangedDelegate(OnNameChanged);
            //caderno.NameChanged += new NameChangedDelegate(OnNameChanged2);
            //caderno.NameChanged += OnNameChanged2;

            caderno.Nome = "Notas Aluno";
            caderno.Nome = "Caderno teste";

            caderno.AddNota(91);
            caderno.AddNota(89.5f);
            caderno.AddNota(75);

            Estatistica estatis = caderno.CalcularEstatistica();
            Console.WriteLine(caderno.Nome);

            WriteResult("Avarage", estatis.AvarageGrade);
            WriteResult("Highest", (int)estatis.HighestGrade);
            WriteResult("Lowest", estatis.LowestGrade);
            Console.ReadKey();


        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Estamos trocando o nome de {args.ExistingName} para {args.NewName} !" );
        }

       /*( static void OnNameChanged2(String existente, string novo)
        {
            Console.WriteLine("***");
        }*/

        static void WriteResult(string descricao, int resultad)
        {
            Console.WriteLine($"{descricao} : {resultad}");
        }

        static void WriteResult(string descricao, float resultad)
        {
            Console.WriteLine($"{descricao} : {resultad}");
        }
    }
}
