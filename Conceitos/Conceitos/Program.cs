using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*CLR  - Manages your aplication 
             * Memory management
             * Operatin system and hardware independence
             * Language independence
            */

            /*FCL - Framework class library
             * A libary of functionality to build applications
             */

            /* Assembly, eh nada mais do que um arquivo que contem codigo compilado. Voce pode ter dois tipos de assemblies, pode ser um arquivo executavel(.exe) ou pode ser uma biblioteca(.dll).
             * Namespaces, tem a ver com escopo das suas classes, eh uma forma de organizar as suas class e eh bastante util para evitar colisao de nomes.
            */

            SpeechSynthesizer fala = new SpeechSynthesizer();
            fala.Speak("Exemplo de referenciar Assembly");

            // Exemplo de um programa simples em c#

            Console.WriteLine("Por gentileza informe o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Bem vindo(a), "+ nome + " ao sistema de sono, poderia nos informar a quantidade de horas você dormiu ontem a noite? ");
            int horas = int.Parse(Console.ReadLine());

            if (horas >= 8)
            {
                Console.WriteLine("Você dormiu bem!! Está descansado, tenha um ótimo dia ! Bom trabalho ");
            }
            else
                Console.WriteLine("Você provavelmente está cansado, acho melhor pegar um cafezinho antes de ir para o trabalho ! ");

            Console.ReadKey();
        }
    }
}
