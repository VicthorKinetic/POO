using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjLista2Ex02
{
    class Calculo
    {

        private int X;


        public void SetX(int X)
        {
            this.X = X;
        }

        public int GetX()
        {
            return X;
        }

        public int Fatorial()
        {
            for (int y = X - 1; y > 0; y--)
            {
                X = X * y;
            }

            return X;
        }

    }
}
