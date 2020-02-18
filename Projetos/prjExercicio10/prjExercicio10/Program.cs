using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            RetCalc rect = new RetCalc();

            Console.Write("Digite a base do retângulo: ");
            rect.setBase(int.Parse(Console.ReadLine()));

            Console.Write("Digite a altura do retângulo: ");
            rect.setAltura(int.Parse(Console.ReadLine()));

            if (rect.calcular() > 100)
            {
                Console.Write("Terreno Grande, ");
            }
            else
            {
                Console.Write("Terreno Pequeno, ");
            }

            Console.Write("um retângulo com " + rect.getBase().ToString() +
                              " de base e " + rect.getAltura().ToString() +
                              " de altura tem área igual a " + rect.calcular().ToString());

            Console.ReadKey();
        }
    }
}
