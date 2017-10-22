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
            IGradeTracker caderno = CreateGradeBook();

            //GetName(caderno);
            AddGrades(caderno);
            SaveGrade(caderno);
            WriteResoults(caderno);

        }

        private static IGradeTracker CreateGradeBook()
        {
            return new ThrowAwayGradeBook();
        }

        private static void WriteResoults(IGradeTracker caderno)
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

        private static void SaveGrade(IGradeTracker caderno)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                caderno.WriteGrades(outputFile);
            }
        }

        private static void AddGrades(IGradeTracker caderno)
        {
            caderno.AddNota(91);
            caderno.AddNota(89.5f);
            caderno.AddNota(75);
        }

        private static void GetName(IGradeTracker caderno)
        {
            try
            {
                Console.WriteLine("Insira um nome:");
                string teste = Console.ReadLine().ToString();
                caderno.Nome = teste;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void WriteResult(string descricao, float resultad)
        {
            Console.WriteLine($"{descricao} : {resultad:f2}", descricao,resultad);
        }

        static void WriteResult(string descricao, string resultad)
        {
            Console.WriteLine($"{descricao} : {resultad}", descricao, resultad);
        }

    }
}
