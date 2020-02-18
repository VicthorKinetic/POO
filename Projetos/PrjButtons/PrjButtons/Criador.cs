using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjButtons
{
    class Criador
    {
        private Form formulario;
        private Button[] botoes = new Button[10];
        private Label[] numeros = new Label[10];
        private PictureBox[] imagens = new PictureBox[10];

        public Criador(Form formulario)
        {
            int topo = 10;

            this.formulario = formulario;

            for(int c=0; c <= 9; c++)
            {
                botoes[c] = new Button();
                botoes[c].Parent = formulario;
                botoes[c].Top = topo;
                botoes[c].Left = 50;
                botoes[c].Text = (c+1).ToString();
                botoes[c].Click += new System.EventHandler(clicouNoBotao);
                topo +=30;
            }
            topo = 10;
             for(int c=0; c <= 9; c++)
            {
                numeros[c] = new Label();
                numeros[c].Parent = formulario;
                numeros[c].Top = topo;
                numeros[c].Left = 150;
                numeros[c].Text = (c+1).ToString();
                topo +=30;
            }
        }
        public void clicouNoBotao(object sender, EventArgs e)
        {
            Button Chamador = (Button)sender;
            MessageBox.Show(Chamador.Text);
        }


 
    }
}
