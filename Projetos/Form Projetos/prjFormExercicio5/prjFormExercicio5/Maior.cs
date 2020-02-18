using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjFormExercicio5
{
    public partial class Maior : Form
    {
        public Maior()
        {
            InitializeComponent();
        }

        private void btn_Veri_Click(object sender, EventArgs e)
        {
            Calculo calc = new Calculo();

            if ((!String.IsNullOrEmpty(txtbox1.Text)) && (!String.IsNullOrEmpty(txtbox2.Text)))
            {
                calc.setn1(int.Parse(txtbox1.Text));
                calc.setn2(int.Parse(txtbox2.Text));

                calc.CalcMaior();

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
