using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjLista2Ex03
{
    class Calculo
    {
        int X = 0;
        int res = 0;
        int y = 0;

        public int Calculos()
        {
            do
            {
                X++;
                do
                {
                    y++;
                    res = y * X;
                    Console.WriteLine(getX().ToString() + " * " + getY().ToString() + " = " + getRes().ToString());
                }
                while (y != 10);
                y = 0;
                Console.WriteLine("");
            }
            while (X != 20);
            return X;
        }


        public int getY()
        {
            return y;
        }

        public int getX()
        {
            return X;
        }

        public int getRes()
        {
            return res;
        }

    }
}
