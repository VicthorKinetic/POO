using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio05
{
    class MilhaMaritima
    {

        private int M;

        public void setM(int M)
        {
            this.M = M;
        }

        public int getM()
        {
            return M;
        }


        public double Converte()
        {
            return M / 1852;
        }


    }
}
