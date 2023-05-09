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

        private void nuevaFrutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevaFruta fruta = new frmNuevaFruta();
            fruta.ShowDialog();
        }

        private void nuevoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoAlumno alumno = new frmNuevoAlumno();
            alumno.ShowDialog();
        }

        private void queFrutasLeGustaAlAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFrutasGustanAlumno fruta = new frmFrutasGustanAlumno();
            fruta.ShowDialog();
        }

        private void consultarAlumnoPorDNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarAlumnoDNI dni = new frmConsultarAlumnoDNI();
            dni.ShowDialog();
        }

        private void consultarQuéFrutasLeGustanAlAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarAlumnoParteNombre f = new frmConsultarAlumnoParteNombre();
            f.ShowDialog();
        }

        private void verTodosLosAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerTodosAlumnos a = new frmVerTodosAlumnos();
            a.ShowDialog();
        }

        private void verTodasLasFrutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerFrutas f = new frmVerFrutas();
            f.ShowDialog();
        }
    }
}
