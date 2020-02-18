using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace prjJogoDaVelhaPOO
{
    class JDV
    {
        private Form formulario;
        private Button[] pollo = new Button[9];
        private int Jogador = 1;
        int topo = 12;
        int esquerda = 3;


        public JDV(Form formulario)
        {
            this.formulario = formulario;

            for (int l = 0; l <= 8; l++)
            {
                pollo[l] = new Button();
                pollo[l].Parent = formulario;
                pollo[l].Top = topo;
                pollo[l].Left = esquerda;
                pollo[l].Height = 98;
                pollo[l].Width = 97;
                pollo[l].Font = new Font("Comic Sans MS", 40f);
                pollo[l].Click += new System.EventHandler(clicouNoBotao);
                esquerda += 103;
                if (esquerda == 312)
                {
                    topo += 103;
                    esquerda = 3;
                }
            }
        }

        private void Repetir()
        {
            pollo[0].Enabled = true;
            pollo[1].Enabled = true;
            pollo[2].Enabled = true;
            pollo[3].Enabled = true;
            pollo[4].Enabled = true;
            pollo[5].Enabled = true;
            pollo[6].Enabled = true;
            pollo[7].Enabled = true;
            pollo[8].Enabled = true;

            pollo[0].Text = "";
            pollo[1].Text = "";
            pollo[2].Text = "";
            pollo[3].Text = "";
            pollo[4].Text = "";
            pollo[5].Text = "";
            pollo[6].Text = "";
            pollo[7].Text = "";
            pollo[8].Text = "";

        }

        private void Verifica()
        {
            if ((pollo[0].Text != "") && (pollo[1].Text != "") && (pollo[2].Text != "") && (pollo[0].Text == pollo[1].Text) && (pollo[1].Text == pollo[2].Text) ||
                (pollo[0].Text != "") && (pollo[3].Text != "") && (pollo[6].Text != "") && (pollo[0].Text == pollo[3].Text) && (pollo[3].Text == pollo[6].Text) ||
                (pollo[0].Text != "") && (pollo[4].Text != "") && (pollo[8].Text != "") && (pollo[0].Text == pollo[4].Text) && (pollo[4].Text == pollo[8].Text) ||
                (pollo[1].Text != "") && (pollo[4].Text != "") && (pollo[7].Text != "") && (pollo[1].Text == pollo[4].Text) && (pollo[4].Text == pollo[7].Text) ||
                (pollo[2].Text != "") && (pollo[5].Text != "") && (pollo[8].Text != "") && (pollo[2].Text == pollo[5].Text) && (pollo[5].Text == pollo[8].Text) ||
                (pollo[2].Text != "") && (pollo[4].Text != "") && (pollo[6].Text != "") && (pollo[2].Text == pollo[4].Text) && (pollo[4].Text == pollo[6].Text) ||
                (pollo[3].Text != "") && (pollo[4].Text != "") && (pollo[5].Text != "") && (pollo[3].Text == pollo[4].Text) && (pollo[4].Text == pollo[5].Text) ||
                (pollo[6].Text != "") && (pollo[7].Text != "") && (pollo[8].Text != "") && (pollo[6].Text == pollo[7].Text) && (pollo[7].Text == pollo[8].Text))
            {
                if (Jogador == 2)
                {
                    MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Repetir();
                }
                else
                {
                    MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Repetir();
                }
            }
            if ((pollo[0].Enabled == false) && (pollo[1].Enabled == false) && (pollo[2].Enabled == false) && (pollo[3].Enabled == false) &&
                (pollo[4].Enabled == false) && (pollo[5].Enabled == false) && (pollo[6].Enabled == false) && (pollo[7].Enabled == false) && (pollo[8].Enabled == false))
            {
                MessageBox.Show("Deu Velha!", "Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Repetir();

            }
        }  


        public void clicouNoBotao(object sender, EventArgs e)
        {
            Button Chamador = (Button)sender;

            if (Jogador == 1)
            {
                Chamador.Text = "X";
                Chamador.Enabled = false;
                Verifica();
                Jogador = 2;

            }
            else
            {
                Chamador.Text = "O";
                Chamador.Enabled = false;
                Verifica();
                Jogador = 1;
            }
               
                  
            }


                 
 
     }
}

    
