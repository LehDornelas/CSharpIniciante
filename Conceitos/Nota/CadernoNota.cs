using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota
{
    //internal - Apenas o mesmo assembly (padrao)
    //private - Apenas a mesma classe
    //public - Todas
    public class CadernoNota
    {
        List<float> notas;
        //ctor - criação de um construtor
        public CadernoNota()
        {
            _nome = "Vazio";
            notas = new List<float>();
        }

        public  Estatistica CalcularEstatistica()
        {
            Estatistica estatis = new Estatistica();

            float sum = 0;
            foreach (float grade in notas)
            {
                estatis.HighestGrade = Math.Max(grade, estatis.HighestGrade);
                estatis.LowestGrade = Math.Min(grade, estatis.LowestGrade);
                sum = sum + grade; //sum += grade;
            }

            estatis.AvarageGrade = sum / notas.Count;
            return estatis;
        }

        internal void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < notas.Count; i++)
            {
                destination.WriteLine(notas[i]);
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                // if(!String.IsNullOrEmpty(value))
                //{

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null ou empty");
                }

                    if (_nome != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _nome;
                        args.NewName = value;
                        //this.
                        NameChanged(this,args);
                    }
                    _nome = value;
               // }
            }
        }

        // public NameChangedDelegate NameChanged; // Only delegate.

        public event NameChangedDelegate NameChanged;

        private string _nome;
        public void AddNota(float nota)
        {
            notas.Add(nota);
        }
    }
}
