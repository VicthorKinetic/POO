using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjFormExercicio3
{
    class Calculo
    {
        private double D;
        private double res;

        public void setD(double D)
        {
            this.D = D;
        }

        public double getD()
        {
            return D;
        }

        public double getRes()
        {
            return res;
        }

        public double AreaDiagonal()
        {
            res = (D * D)/2;
            return res;
        }
    }
}
