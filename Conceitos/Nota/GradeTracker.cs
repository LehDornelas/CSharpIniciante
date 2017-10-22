using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota
{
    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddNota(float grade);
        public abstract Estatistica CalcularEstatistica();
        public abstract void WriteGrades(TextWriter destination);
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

                if (_nome != value && NameChanged != null)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _nome;
                    args.NewName = value;
                    //this.
                    NameChanged(this, args);
                }
                _nome = value;
                // }
            }
        }

        public event NameChangedDelegate NameChanged;

        protected string _nome;
    }
}
