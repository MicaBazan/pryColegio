using System;
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
    public partial class frmVerTodosAlumnos : Form
    {
        clsAlumno a;
        public frmVerTodosAlumnos()
        {
            InitializeComponent();
        }

        private void frmVerTodosAlumnos_Load(object sender, EventArgs e)
        {
            a = new clsAlumno();

            a.verTodo(dgvAlumnos);
        }
    }
}
