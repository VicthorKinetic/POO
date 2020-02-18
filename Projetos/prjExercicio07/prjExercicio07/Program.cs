using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            DolarReal real = new DolarReal();

            Console.WriteLine("Digite a quantia em Dolar:");
            real.setD(double.Parse(Console.ReadLine()));

            Console.WriteLine("");

            Console.WriteLine("A quantia de " + real.getC().ToString() + " Dolares ,convertida para reais é " + real.converte().ToString());

            Console.ReadKey();


        }
    }
}
