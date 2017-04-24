using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "teste1,teste2,teste3";

            string s2 = "teste1";
            s2 += ",teste2";

            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append("teste1");
            sb.Append(",teste2");

            //s2.EndsWith("2");
            //s2.Equals("");
            //s2.Removo(4,3);
            //string[] s3 = s2.Split(',');

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(sb);
            Console.ReadKey();

        }
    }
}
