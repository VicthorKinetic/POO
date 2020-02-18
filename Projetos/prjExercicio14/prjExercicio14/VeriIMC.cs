using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio14
{
    class VeriIMC
    {
        private double p;
        private double h;
        private string s;

        public void setPeso(double p)
        {
            this.p = p;
        }

        public void setAltura(double h)
        {
            this.h = h;
        }

        public void setSexo(string s)
        {
            this.s = s;
        }

        public double getPeso()
        {
            return p;
        }

        public double getAltura()
        {
            return h;
        }

        public string getSexo()
        {
            return s;
        }

        public double calcular()
        {
            return p / (h * h);
        }
    }
}
