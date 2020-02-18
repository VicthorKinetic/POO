using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            CelsiusFahrenheit celsius = new CelsiusFahrenheit();

            Console.WriteLine("Digite a temperatura em Celsius:");
            celsius.setC(int.Parse(Console.ReadLine()));

            Console.WriteLine("");

            Console.WriteLine("A temperatura de " + celsius.getC().ToString() + " em Celsius é igual a " + celsius.converte().ToString() + " em Fahrenheit.");

            Console.ReadKey();

        }
    }
}
