using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjFormExercicio1
{
    public partial class Retângulo : Form
    {
        public Retângulo()
        {
            InitializeComponent();
        }

        private void btn_Efetuar_Click(object sender, EventArgs e)
        {
            Calculo calc = new Calculo();

            if ((!String.IsNullOrEmpty(txtbox1.Text)) && (!String.IsNullOrEmpty(txtbox2.Text)))
            {
                calc.setB(int.Parse(txtbox1.Text));
                calc.setH(int.Parse(txtbox2.Text));

                calc.CalcularArea();

                lbl_display.Visible = true;
                lbl_display.Text = calc.getRes().ToString();
            }
            else
            {
                MessageBox.Show("Complete todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void txtbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
