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
    public partial class frmConsultarAlumnoDNI : Form
    {
        public frmConsultarAlumnoDNI()
        {
            InitializeComponent();
        }

        clsAlumno a = new clsAlumno();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            a.Dni = Convert.ToInt32(txtDni.Text);
            a.buscar();
            txtNombre.Text = a.Nombre;
            if (a.Nombre == "")
            {
                pbFoto.Image = null;
                MessageBox.Show("Alumno no encontrado", "SIN DATOS");

            }
            else
            {
                pbFoto.Load("fotos/" + a.Foto);
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.Text != string.Empty)
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }

        private void frmConsultarAlumnoDNI_Load(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
        }
    }
}
