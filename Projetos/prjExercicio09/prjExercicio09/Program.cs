using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            VeriNum maior = new VeriNum();

            Console.Write("Digite um número: ");
            maior.setN1(int.Parse(Console.ReadLine()));

            Console.Write("Digite outro número: ");
            maior.setN2(int.Parse(Console.ReadLine()));

            if (maior.n1 == maior.n2)
            {
                Console.WriteLine("Os números são iguais");
            }
            else
            {
                Console.WriteLine("O número maior é " + maior.verifica().ToString());
            }

            Console.ReadKey();
        }
    }
}
