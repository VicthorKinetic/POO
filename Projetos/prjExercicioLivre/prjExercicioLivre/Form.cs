﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjExercicioLivre
{
    public partial class Form : Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void BlazBlue_Load(object sender, EventArgs e)
        {
            Blazblue blazblue = new Blazblue(this);
        }
    }
}
