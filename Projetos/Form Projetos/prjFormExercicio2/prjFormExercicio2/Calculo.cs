using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjFormExercicio2
{
    class Calculo
    {
        private int A;
        private int res;

        public void setA(int A)
        {
            this.A = A;
        }

        public int getA()
        {
            return A;
        }

        public int getRes()
        {
            return res;
        }

        public int AreaArestas()
        {
            res = A * A;
            return res;
        }
    }
}
