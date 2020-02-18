using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaArestaQuadrado quadrado = new AreaArestaQuadrado();

            Console.WriteLine("Digite o valor da aresta do quadrado:");
            quadrado.setA(int.Parse(Console.ReadLine()));

            Console.WriteLine("");

            Console.WriteLine("A área do quadrado com o valor das arestas de "+quadrado.getA().ToString()+" é:"+quadrado.AreaArestas().ToString());

            Console.ReadKey();

        }
    }
}
