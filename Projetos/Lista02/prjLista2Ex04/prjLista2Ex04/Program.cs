using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjLista2Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            VerificaNumero Veri = new VerificaNumero();

            Console.Write("Digite um valor: ");
            Veri.SetN1(int.Parse(Console.ReadLine()));

            Console.Write("Digite um valor maior que o primeiro: ");
            Veri.SetN2(int.Parse(Console.ReadLine()));

            if (Veri.GetN1() > Veri.GetN2())
            {
                Veri.Verificação();
            }

            Console.Write("Número 1: " + Veri.GetN1().ToString() + " " + "Número 2: " + Veri.GetN2().ToString());

            Console.ReadKey();

        }
    }
}
