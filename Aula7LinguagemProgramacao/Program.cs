using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7LinguagemProgramacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            src.VerificaPares teste = new src.VerificaPares(10);

            while (!teste.terminou())
            {
                if(teste.par())
                    Console.WriteLine("{0} é par", teste.Valor);

                teste.progride();
            }

            Console.WriteLine("Fim");
            Console.ReadLine();
        }
    }
}
