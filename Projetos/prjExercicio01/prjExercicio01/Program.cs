using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio01
{
    class Program
    {
        static void Main(string[] args)
        {

            AreaRetangulo retangulo = new AreaRetangulo();

                Console.WriteLine("Digite a Base do Retangulo:");
                retangulo.setB(int.Parse(Console.ReadLine()));

                Console.WriteLine("");

                Console.WriteLine("Digite a Altura do Retangulo:");
                retangulo.setH(int.Parse(Console.ReadLine()));

                Console.WriteLine("");

                Console.WriteLine("A área do retangulo com base " + retangulo.getB().ToString() + " e altura "+ retangulo.getH().ToString() + " é: "+retangulo.CalcularArea().ToString());

                Console.ReadKey();

        }
    }
}
