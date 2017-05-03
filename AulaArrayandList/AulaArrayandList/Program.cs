using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            //exemplo lista
            List<int> lista = new List<int>();
            lista.Add(1);

            //exemplo do while
            int a = 1;
            do
            {
                Console.WriteLine(a.ToString());
                a = a+1;
            } while (a <= 10);
            Console.ReadKey();
        }
    }
}
