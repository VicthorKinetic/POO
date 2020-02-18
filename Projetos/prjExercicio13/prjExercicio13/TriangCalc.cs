using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio13
{
    class TriangCalc
    {
        private int a;
        private int b;
        private int c;

        public void setA(int a)
        {
            this.a = a;
        }

        public void setB(int b)
        {
            this.b = b;
        }

        public void setC(int c)
        {
            this.c = c;
        }

        public int getA()
        {
            return a;
        }

        public int getB()
        {
            return b;
        }

        public int getC()
        {
            return c;
        }

        public int calcularA()
        {
            return a * a;
        }
        public int calcularB()
        {
            return b * b;
        }
        public int calcularC()
        {
            return c * c;
        }
    }
}
