using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio14
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

            Console.Write("Digite seu sexo(M ou F): ");
            imc.setSexo(Console.ReadLine());

            if (imc.getSexo() == "M" || imc.getSexo() == "m")
            {
                if (imc.calcular() < 20)
                    Console.Write("Você está abaixo do peso");
                else
                    if (imc.calcular() >= 25)
                        Console.Write("Você está acima do peso");
                    else
                        Console.Write("Você está no seu peso ideal!");
            }

            if (imc.getSexo() == "F" || imc.getSexo() == "f")
            {
                if (imc.calcular() < 19)
                    Console.Write("Você está abaixo do peso");
                else
                    if (imc.calcular() >= 24)
                        Console.Write("Você está acima do peso");
                    else
                        Console.Write("Você está no seu peso ideal!");
            }

          Console.ReadKey();
        }
    }
}
