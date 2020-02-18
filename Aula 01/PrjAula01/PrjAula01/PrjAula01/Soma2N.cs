using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjAula01
{
    class Soma2N
    {
        //Atributos privados
        private int n1;
        private int n2;

        //Propriedades
        public void setN1(int n1)
        {
            this.n1 = n1;
        }

        public void setN2(int n2)
        {
            this.n2 = n2;
        }

        public int getN1()
        {
            return n1;
        }

        public int getN2()
        {
            return n2;
        }

        //Método principal
        public int calcular()
        {
            return n1 + n2;
        }
    }
}
