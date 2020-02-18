using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjFormExercicio4
{
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void btn_Veri_Click(object sender, EventArgs e)
        {
            Calculo calc = new Calculo();

            if ((!String.IsNullOrEmpty(txtbox1.Text)) && (!String.IsNullOrEmpty(txtbox2.Text)))
            {
                calc.setB(int.Parse(txtbox1.Text));
                calc.setH(int.Parse(txtbox2.Text));

                calc.Area();

                lbl_display.Visible = true;
                lbl_display.Text = calc.getRes().ToString();
            }
            else
            {
                MessageBox.Show("Complete os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
