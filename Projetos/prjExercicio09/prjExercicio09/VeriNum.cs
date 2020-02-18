using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio09
{
    class VeriNum
    {
        public int n1;
        public int n2;

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

        public int verifica()
        {
            if (n1 > n2)
                return n1;
            else
                return n2;
        }
        
    }
}
