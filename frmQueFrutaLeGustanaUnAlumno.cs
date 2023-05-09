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
    public partial class frmQueFrutaLeGustanaUnAlumno : Form
    {
        clsAlumno a;
        clsGustan g;
        clsFruta f;
        public frmQueFrutaLeGustanaUnAlumno()
        {
            InitializeComponent();
        }

        private void frmQueFrutaLeGustanaUnAlumno_Load(object sender, EventArgs e)
        {
            a = new clsAlumno();

            cbAlumno.DisplayMember = "nombre";
            cbAlumno.ValueMember = "dni";
            cbAlumno.DataSource = a.getAlumnos();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(cbAlumno.SelectedValue);

            
        }
    }
}
