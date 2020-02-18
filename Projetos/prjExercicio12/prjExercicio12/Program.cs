using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            TipoTriangulo triangulo = new TipoTriangulo();

            Console.WriteLine("Digite o 1° valor");
            triangulo.setX(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o 2° valor");
            triangulo.setY(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o 3° valor");
            triangulo.setZ(int.Parse(Console.ReadLine()));

            Console.WriteLine("");

            Console.WriteLine("O triangulo é um: "+triangulo.verifica() );

            Console.ReadKey();

        }
    }
}
