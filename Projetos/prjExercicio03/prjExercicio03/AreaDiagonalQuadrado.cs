using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio03
{
    class AreaDiagonalQuadrado
    {

        private double D;


        public void setD(double D)
        {
            this.D = D;
        }

        public double getD()
        {
            return D;
        }

        public double CalcularArea()
        {
            return (D * D)/2;
        }

    }
}
