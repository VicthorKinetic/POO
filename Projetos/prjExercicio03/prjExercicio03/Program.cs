using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaDiagonalQuadrado quadrado = new AreaDiagonalQuadrado();

            Console.WriteLine("Digite a diagonal do quadrado:");
            quadrado.setD(int.Parse(Console.ReadLine()));

            Console.WriteLine("");

            Console.WriteLine("A área do quadrado com diagonal "+quadrado.getD().ToString()+" é: " +quadrado.CalcularArea().ToString());

            Console.ReadKey();
        }
    }
}
