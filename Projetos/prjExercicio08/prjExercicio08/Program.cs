using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            VeriMaior maior = new VeriMaior();

            Console.Write("Digite um número: ");
            maior.setN1(int.Parse(Console.ReadLine()));

            Console.Write("Digite outro número: ");
            maior.setN2(int.Parse(Console.ReadLine()));

            Console.WriteLine("O número maior é " + maior.verifica().ToString());

            Console.ReadKey();
        }
    }
}
