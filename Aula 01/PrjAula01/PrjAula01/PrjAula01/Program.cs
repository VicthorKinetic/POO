using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjAula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma2N soma2N = new Soma2N();

            Console.WriteLine("Digite o 1º número: ");
            soma2N.setN1(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o 2º número: ");
            soma2N.setN2(int.Parse(Console.ReadLine()));

            Console.WriteLine("Resultado de " + soma2N.getN1().ToString() + " + " + soma2N.getN2().ToString() + " = " + soma2N.calcular().ToString());

            Console.ReadKey();
        }
    }
}
