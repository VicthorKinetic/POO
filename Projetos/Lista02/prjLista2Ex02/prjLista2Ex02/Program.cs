using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjLista2Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo cal = new Calculo();

            Console.WriteLine("Digite o valor para o fatorial:");
            cal.SetX(int.Parse(Console.ReadLine()));

            Console.WriteLine("A fatorial de "+cal.GetX().ToString()+" é: "+cal.Fatorial().ToString());

            Console.ReadKey();

        }
    }
}
