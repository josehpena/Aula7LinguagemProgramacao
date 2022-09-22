using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7LinguagemProgramacao.src
{
    internal class VerificaPares
    {
        private int valor;
        List<int> list = new List<int>();
        int[] vetor;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public VerificaPares(int valor) { 

            this.valor = valor;
            
        }

        public bool terminou()
        {
            if(this.valor == 0)
            {
                vetor = new int[list.Count];
                for(int i = 0; i < vetor.Length;i++)
                {
                    vetor[i] = list[i];
                }
                return true;
            }

            return false;

        }

        public void par()
        {
            if (this.valor % 2 == 0)
            {
                list.Add(this.valor);
            }
        }

        public void progride()
        {
            this.valor--;
        }
    }
}
