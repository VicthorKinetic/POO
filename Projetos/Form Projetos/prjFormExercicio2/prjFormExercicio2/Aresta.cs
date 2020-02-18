using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjFormExercicio2
{
    public partial class Aresta : Form
    {
        public Aresta()
        {
            InitializeComponent();
        }

        private void btn_Veri_Click(object sender, EventArgs e)
        {
            Calculo calc = new Calculo();

            if (!String.IsNullOrEmpty(txtbox1.Text))
            {
                calc.setA(int.Parse(txtbox1.Text));

                calc.AreaArestas();

                lbl_display.Visible = true;
                lbl_display.Text = calc.getRes().ToString();
            }
            else
            {
                MessageBox.Show("Complete o campo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
