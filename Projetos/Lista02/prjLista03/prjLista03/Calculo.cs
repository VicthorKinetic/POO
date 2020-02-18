using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjLista03
{
    class Calculo
    {

        private int X;
        private int n100;
        private int n50;
        private int n20;
        private int n10;


        public void SetX(int X)
        {
            this.X = X;
        }

        public int GetX()
        {
            return X;
        }

        public int Getn100()
        {
            return n100;
        }

        public int Getn50()
        {
            return n50;
        }

        public int Getn20()
        {
            return n20;
        }

        public int Getn10()
        {
            return n10;
        }

        public void VerificaNum()
        {
            do
            {
                Console.Write("Digite um valor múltiplo de 10: ");
                SetX(int.Parse(Console.ReadLine()));
            }
            while (X%10 != 0);
        }

        public int VerificaCalc100()
        {
            if (X - 100 >= 0)
            {
                do
                {
                    if (X - 100 >= 0)
                    {
                        n100++;
                        X = X - 100;
                    }
                }
                while (X >= 100);
            }
            return n100;
               
        }

        public int VerificaCalc50()
        {
            if (X - 50 >= 0)
            {
                do
                {
                    if (X - 50 >= 0)
                    {
                        n50++;
                        X = X - 50;
                    }
                }
                while (X >= 50);
            }
            return 50;
        }
        public int VerificaCalc20()
        {
            if (X - 20 >= 0)
                    {
                        do
                        {
                            if (X - 20 >= 0)
                            {
                                n20++;
                                X = X - 20;
                            }
                        }
                        while (X >= 20);
                    }
            return n20;
        }
        public int VerificaCalc10()
        {

            if (X - 10 >= 0)
            {
                do
                {
                    if (X - 10 >= 0)
                    {
                        n10++;
                        X = X - 10;
                    }
                }
                while (X >= 10);
            }
            return n10;
        }
    }
}
