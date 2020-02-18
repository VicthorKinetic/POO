using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio11
{
    class VeriIMC
    {
        private double p;
        private double h;

        public void setPeso(double p)
        {
            this.p = p;
        }

        public void setAltura(double h)
        {
            this.h = h;
        }

        public double getPeso()
        {
            return p;
        }

        public double getAltura()
        {
            return h;
        }

        public double calcular()
        {
            return p / (h * h);
        }
    }

}
