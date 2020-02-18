using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjLista2Ex01
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Verificação Very=new Verificação();

            Console.WriteLine("Por Favor digite a Altura: ");

            Very.setH(int.Parse(Console.ReadLine()));

            Console.WriteLine("Por Favor digite a Base: ");

            Very.setL(int.Parse(Console.ReadLine()));

            if (Very.GetH() == Very.GetL())
            {
                Very.VerificaQuadrado();
            }

            else
            {
                Console.WriteLine("Não é um quadrado");
            }

            Console.WriteLine("A area é de: " + Very.VerificaArea().ToString());
            Console.WriteLine("O perimetro é de: " + Very.VerificaPerimetro().ToString());
            Console.ReadKey();
        }
    }
}
