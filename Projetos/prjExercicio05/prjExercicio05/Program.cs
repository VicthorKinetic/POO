using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            MilhaMaritima quilometro = new MilhaMaritima();

            Console.WriteLine("Digite a distancia em milhas maritimas:");
            quilometro.setM(int.Parse(Console.ReadLine()));

            Console.WriteLine("");

            Console.WriteLine("A distancia de " + quilometro.getM().ToString() + " convertida em quilometros é: " + quilometro.Converte().ToString());

            Console.ReadKey();

        }
    }
}
