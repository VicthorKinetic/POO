using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio07
{
    class DolarReal
    {

        private double D;

        public void setD(double D)
        {
            this.D = D;
        }

        public double getC()
        {
            return D;
        }


        public double converte()
        {
            return D * 3.5;
        }

    }
}
