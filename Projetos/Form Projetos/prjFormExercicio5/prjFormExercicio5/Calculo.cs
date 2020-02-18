using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjFormExercicio5
{
    class Calculo
    {
        private int n1;
        private int n2;
        private int res;

        public void setn1(int n1)
        {
            this.n1 = n1;
        }

        public int getn1()
        {
            return n1;
        }

        public void setn2(int n2)
        {
            this.n2 = n2;
        }

        public int getn2()
        {
            return n2;
        }

        public int getRes()
        {
            return res;
        }

        public int CalcMaior()
        {
            if (n1 > n2)
            {
                res = n1;
                return res;
            }

            else
            {
                if (n2 > n1)
                {
                    res = n2;
                    return res;
                }
            }
            return res;
        }
    }
}
