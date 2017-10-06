using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota
{
    public class NameChangedEventArgs : EventArgs
    {
        //prop 
        public string ExistingName { get; set; }

        public string NewName { get; set; }
    }
}
