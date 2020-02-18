using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio12
{
    class TipoTriangulo
    {
        private int Z;
        private int Y;
        private int X;

        public void setX(int X)
        {
            this.X = X;
        }

        public void setY(int Y)
        {
            this.Y = Y;
        }

        public void setZ(int Z)
        {
            this.Z = Z;
        }

        public int getX()
        {
            return X;
        }

        public int getY()
        {
            return Y;
        }

        public int getZ()
        {
            return Z;
        }

        public string verifica()
        {

            if (X != Y && X != Z && Z != Y)
                return "Escaleno";
            else
                if (X == Y && Z == X && Y == Z)
                    return "Eqüilátero";
                else
                    if ((X == Y && X != Z) || (X == Z && X != Y) || (Z == Y && Z != X))
                        return "Isósceles";
                    else
                        return "Não é um Triangulo";
        }

    }
}
