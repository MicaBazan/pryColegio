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
    public partial class frmConsultarAlumnoParteNombre : Form
    {

        clsAlumno a;

        public frmConsultarAlumnoParteNombre()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            a.ver(dgvAlumno, txtNombre.Text);
        }

        private void frmConsultarAlumnoParteNombre_Load(object sender, EventArgs e)
        {
            a = new clsAlumno();
        }
    }
}
