using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            VeriIMC imc = new VeriIMC();

            Console.Write("Digite seu peso: ");
            imc.setPeso(double.Parse(Console.ReadLine()));

            Console.Write("Digite sua altura: ");
            imc.setAltura(double.Parse(Console.ReadLine()));

            if (imc.calcular() < 20)
                Console.Write("Você está abaixo do peso");
            else
                if(imc.calcular() >= 25)
                    Console.Write("Você está acima do peso");
                else
                    Console.Write("Você está no seu peso ideal!");

            Console.ReadKey();
        }
    }
}
