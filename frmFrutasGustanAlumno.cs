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
    public partial class frmFrutasGustanAlumno : Form
    {
        public frmFrutasGustanAlumno()
        {
            InitializeComponent();
        }

        clsGustan gustan = new clsGustan();
        private void frmFrutasGustanAlumno_Load(object sender, EventArgs e)
        {
            clsFruta fruta = new clsFruta();

            cbFruta.DisplayMember = "nombre";
            cbFruta.ValueMember = "fruta";
            cbFruta.DataSource = fruta.getFrutas();

            clsAlumno alumno = new clsAlumno();

            cbAlumno.DisplayMember = "nombre";
            cbAlumno.ValueMember = "dni";
            cbAlumno.DataSource = alumno.getAlumnos();

        }
    }
}
