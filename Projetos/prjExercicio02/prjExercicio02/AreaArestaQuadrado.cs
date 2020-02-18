using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio02
{
    class AreaArestaQuadrado
    {

        private int A;

        public void setA(int A)
        {
            this.A = A;
        }

        public int getA()
        {
            return A;
        }

        public int AreaArestas()
        {
            return A * A;
        }

    }
}
