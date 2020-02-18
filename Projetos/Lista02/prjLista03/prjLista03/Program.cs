using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjLista03
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo cal = new Calculo();

            Console.Write("Digite um valor múltiplo de 10: ");
            cal.SetX(int.Parse(Console.ReadLine()));

            if (cal.GetX()%10 != 0)
            {
                cal.VerificaNum();
            }

            cal.VerificaCalc100();
            cal.VerificaCalc50();
            cal.VerificaCalc20();
            cal.VerificaCalc10();

            Console.Write(cal.Getn100() + " Notas de 100, " + cal.Getn50() + " Notas de 50, " + cal.Getn20() + " Notas de 20, " + cal.Getn10() + " Notas de 10.");

            Console.ReadKey();
        }
    }
}
