using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio04
{
    class AreaTriangulo
    {

        private int B;
        private int H;


        public void setB(int B)
        {
            this.B = B;
        }

        public void setH(int H)
        {
            this.H = H;
        }

        public int getB()
        {
            return B;
        }

        public int getH()
        {
            return H;
        }


        public int CalcularArea()
        {
            return (B * H)/2;
        }

    }
}
