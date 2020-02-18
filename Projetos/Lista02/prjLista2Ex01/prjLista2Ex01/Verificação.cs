using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjLista2Ex01
{
    class Verificação
    {
        private int H;
        private int L;


        public void setH(int H)
        {
            this.H = H;
        }

        public void setL(int L)
        {
            this.L = L;
        }

        public int GetH()
        {
            return H;
        }

        public int GetL()
        {
            return L;
        }

        public int VerificaArea()
        {
            return H * L;
        }

        public int VerificaPerimetro() 
        {
            return H + H + L + L;
 
        }

        public void VerificaQuadrado()
        {
            Console.WriteLine("Sim é um quadrado");
        }

        


    }
}
