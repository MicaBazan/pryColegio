﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryColegio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoBarrio barrio = new frmNuevoBarrio();
            barrio.ShowDialog();
        }
    }
}