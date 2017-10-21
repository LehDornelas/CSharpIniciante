using System;
using System.Collections.Generic;
using System.IO;
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

            GetName(caderno);
            AddGrades(caderno);
            SaveGrade(caderno);
            WriteResoults(caderno);

        }

        private static void WriteResoults(CadernoNota caderno)
        {
            Estatistica estatis = caderno.CalcularEstatistica();
            //Console.WriteLine(caderno.Nome);

            WriteResult("Avarage", estatis.AvarageGrade);
            WriteResult("Highest", estatis.HighestGrade);
            WriteResult("Lowest", estatis.LowestGrade);
            WriteResult("Grade", estatis.LetterGrade);
            WriteResult(estatis.Description, estatis.LetterGrade);
            Console.ReadKey();
        }

        private static void SaveGrade(CadernoNota caderno)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                caderno.WriteGrades(outputFile);
            }
        }

        private static void AddGrades(CadernoNota caderno)
        {
            caderno.AddNota(91);
            caderno.AddNota(89.5f);
            caderno.AddNota(75);
        }

        private static void GetName(CadernoNota caderno)
        {
            try
            {
                Console.WriteLine("Insira um nome:");
                caderno.Nome = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Deu ruim", ex);
            }
        }

        /* static void OnNameChanged(object sender, NameChangedEventArgs args)
         {
             Console.WriteLine($"Estamos trocando o nome de {args.ExistingName} para {args.NewName} !" );
         }*/

        /*( static void OnNameChanged2(String existente, string novo)
         {
             Console.WriteLine("***");
         }*/

        static void WriteResult(string descricao, float resultad)
        {
            Console.WriteLine($"{descricao} : {resultad:f2}", descricao,resultad);
        }

        static void WriteResult(string descricao, string resultad)
        {
            Console.WriteLine($"{descricao} : {resultad}", descricao, resultad);
        }


        /*static void WriteResult(string descricao, float resultad)
        {
            Console.WriteLine($"{descricao} : {resultad}");
        }*/
    }
}
