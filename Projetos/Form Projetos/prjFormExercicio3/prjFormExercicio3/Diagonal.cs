using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjFormExercicio3
{
    public partial class Diagonal : Form
    {
        public Diagonal()
        {
            InitializeComponent();
        }

        private void btn_Veri_Click(object sender, EventArgs e)
        {
            Calculo calc = new Calculo();

            if (!String.IsNullOrEmpty(txtbox1.Text))
            {
                calc.setD(int.Parse(txtbox1.Text));

                calc.AreaDiagonal();

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
