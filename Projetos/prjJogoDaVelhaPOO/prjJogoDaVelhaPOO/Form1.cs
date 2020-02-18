using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjJogoDaVelhaPOO
{
    public partial class JogoDaVelha : Form
    {
        public JogoDaVelha()
        {
            InitializeComponent();
        }

        private void JogoDaVelha_Load(object sender, EventArgs e)
        {
            JDV jdv = new JDV(this);
        }
    }
}
