using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjLista2Ex04
{
    class VerificaNumero
    {
        private int n1;
        private int n2;


        public void SetN1(int n1)
        {
            this.n1 = n1;
        }

        public void SetN2(int n2)
        {
            this.n2 = n2;
        }

        public int GetN1()
        {
            return n1;
        }

        public int GetN2()
        {
            return n2;
        }

        public int Verificação()
        {
            if (n1 > n2)
                do
                {
                    Console.Write("Digite um valor maior que o primeiro: ");
                    SetN2(int.Parse(Console.ReadLine()));
                }
                while (n1 > n2);

            return n2;
        }

    }
}
