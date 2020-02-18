using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjFormExercicio4
{
    class Calculo
    {
        private int B;
        private int H;
        private int res;

        public void setB(int B)
        {
            this.B = B;
        }

        public int getB()
        {
            return B;
        }

        public void setH(int H)
        {
            this.H = H;
        }

        public int getH()
        {
            return H;
        }

        public int getRes()
        {
            return res;
        }

        public int Area()
        {
            res = B * H;
            return res;
        }
    }
}
