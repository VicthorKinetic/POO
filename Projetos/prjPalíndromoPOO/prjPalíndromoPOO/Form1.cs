using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjPalíndromoPOO
{

    public partial class Form1 : Form
    {

        Pali pali = new Pali();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Veri_Click(object sender, EventArgs e)
        {
            pali.setpergunta(txt_pergunta.Text);

            for (int i = pali.pergunta.Length - 1; i > -1; i--)
            {
                if (pali.pergunta[i].ToString() != " ")
                {
                    pali.veri = pali.veri + pali.pergunta[i].ToString();
                }
            }


            for (int i = 0; i < pali.pergunta.Length; i++)
            {
                if (pali.pergunta[i].ToString() != " ")
                {
                    pali.atras = pali.atras + pali.pergunta[i].ToString();
                }
            }

            pali.VeriPali();

            pali.VeriCorno();

            pali.atras = "";
            txt_pergunta.Text = "";
            pali.veri = "";
            pali.corno = false;
        }
    }
}
