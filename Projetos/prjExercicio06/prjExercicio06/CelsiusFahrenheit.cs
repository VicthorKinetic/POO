using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio06
{
    class CelsiusFahrenheit
    {

        private int C;

        public void setC(int C)
        {
            this.C = C;
        }

        public int getC()
        {
            return C;
        }


        public double converte()
        {
            return (C * 1.8) + 32;
        }


    }
}
