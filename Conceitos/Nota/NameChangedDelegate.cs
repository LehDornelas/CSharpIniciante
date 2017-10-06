using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota
{
    //When I need a variable that references a method, a dalegate is a type that references methods
    public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args);
}
