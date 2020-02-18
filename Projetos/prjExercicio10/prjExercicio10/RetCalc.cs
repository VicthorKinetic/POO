using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio10
{
    class RetCalc
    {
        private int x;
        private int y;

        public void setBase(int x)
        {
            this.x = x;
        }

        public void setAltura(int y)
        {
            this.y = y;
        }

        public int getBase()
        {
            return x;
        }

        public int getAltura()
        {
            return y;
        }

        public int calcular()
        {
            return x * y;
        }
    }
}
