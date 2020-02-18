using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjPalíndromoPOO
{
    class Pali
    {
        public string pergunta;
        public string atras;
        public string veri;
        public bool corno;

        public string setpergunta(string per)
        {
            return pergunta = per;
        }
       

        public bool VeriPali()
        {

            for (int a = atras.Length - 1; a > 0; a--)
            {
                if (atras[a].ToString() != veri[a].ToString())
                {
                    corno = true;
                }
            }

            return corno;

        }

        public void VeriCorno()
        {
            if (corno != true)
            {
                MessageBox.Show("É um Palíndromo");
            }
            else
            {
                if (corno != false)
                {
                    MessageBox.Show("Não é um Palíndromo");
                }
            }
        }

    }
}
