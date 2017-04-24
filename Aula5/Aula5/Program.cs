using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando Array 
            int[] a1 = new int[3];
            a1[0] = 1;
            a1[1] = 2;
            a1[2] = 3;
            //a1[5] = 5; - Erro

            int[] a2 = new int[] { 10, 20, 30 };

            string[] a3 = { "um", "dois" };

            //Tamanho do array 
            Console.WriteLine(a3.Length);

            //Declarando Array multidimencional
            int[,] ma1 = new int[5,10];
            ma1[0, 0] = 10;

            //Lista de Array
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("teste");
            al.Add(true);

                       

        }
    }
}
