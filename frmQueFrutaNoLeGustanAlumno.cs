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
    public partial class frmQueFrutaNoLeGustanAlumno : Form
    {
        clsAlumno a;
        clsGustan g;
        public frmQueFrutaNoLeGustanAlumno()
        {
            InitializeComponent();
        }

        private void frmQueFrutaNoLeGustanAlumno_Load(object sender, EventArgs e)
        {
            a = new clsAlumno();

            cbNombre.DisplayMember = "nombre";
            cbNombre.ValueMember = "dni";
            cbNombre.DataSource = a.getAlumnos();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            g = new clsGustan();

            int dni = Convert.ToInt32(cbNombre.SelectedValue);

            g.verNo(dgvFruta, dni);
        }
    }
}
