using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = Convert.ToInt32(Console.ReadKey());
            int n2 = Convert.ToInt32(Console.ReadKey());

            #region if

            if (n1==n2)
            {
                Console.WriteLine("É verdade!");
            } else
            {
                Console.WriteLine("É falso!");
            }
            Console.ReadKey();
            #endregion

            #region switch

            switch (n1 == n2)
            {
                case true:
                    Console.WriteLine("É verdade!");
                    break;
                case false:
                    Console.WriteLine("É falso!");
                    break;
                default:
                    Console.WriteLine("Não é verdadeiro nem falso!!");
                    break;
            }

            #endregion switch
        }
    }
}
