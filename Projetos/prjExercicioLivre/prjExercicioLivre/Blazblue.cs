using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjExercicioLivre
{
    class Blazblue
    {
        private Form formulario;
        private Button[] botao = new Button[6];
        private String[] nomes = new String[6];

        public Blazblue(Form formulario)
        {
            int i;
            int topo = 10;

            this.formulario = formulario;

            for(i=0; i<10; ++i)
            {
                botao[i] = new Button();
                botao[i].Parent = formulario;
                botao[i].Top = topo;
                botao[i].Left = 50;
                botao[i].Text = nomes[i+1].ToString();
                botao[i].Click += new System.EventHandler(Clickar);
                topo += 30;
            }
        }


        public void Clickar(object sender, EventArgs e)
        {
            Button Chamador = (Button)sender;
            MessageBox.Show(Chamador.Text);
        }

    }
}
