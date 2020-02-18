using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaTriangulo triangulo = new AreaTriangulo();

            Console.WriteLine("Digite a Base do triangulo:");
            triangulo.setB(int.Parse(Console.ReadLine()));

            Console.WriteLine("");

            Console.WriteLine("Digite a Altura do Retangulo:");
            triangulo.setH(int.Parse(Console.ReadLine()));

            Console.WriteLine("");

            Console.WriteLine("A área do retangulo com base " + triangulo.getB().ToString() + " e altura " + triangulo.getH().ToString() + " é: " + triangulo.CalcularArea().ToString());

            Console.ReadKey();

        }
    }
}
