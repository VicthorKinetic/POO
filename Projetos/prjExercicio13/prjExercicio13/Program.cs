using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangCalc tri = new TriangCalc();

            Console.Write("Digite um lado do triângulo: ");
            tri.setA(int.Parse(Console.ReadLine()));

            Console.Write("Digite outro lado do triângulo: ");
            tri.setB(int.Parse(Console.ReadLine()));

            Console.Write("Digite mais um lado do triângulo: ");
            tri.setC(int.Parse(Console.ReadLine()));

            if (tri.calcularA() == tri.calcularB() + tri.calcularC())
                 Console.WriteLine("É um triangulo, a hipotenusa é o " + tri.getA().ToString());
            else
                if (tri.calcularB() == tri.calcularA() + tri.calcularC())
                    Console.WriteLine("É um triangulo, a hipotenusa é o " + tri.getB().ToString());
                else
                    if (tri.calcularC() == tri.calcularB() + tri.calcularA())
                     Console.WriteLine("É um triangulo, a hipotenusa é o " + tri.getC().ToString());
                    else 
                        Console.WriteLine("Não é um triângulo retângulo");

            Console.ReadKey();
        }
    }
}
