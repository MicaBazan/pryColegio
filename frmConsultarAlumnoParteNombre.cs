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
    public partial class frmConsultarAlumnoParteNombre : Form
    {
        DataTable tabla;
        clsAlumno a;
        clsBarrio b;
        public frmConsultarAlumnoParteNombre()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvAlumno.Rows.Clear();

            string queBusco = txtNombre.Text;
            string nombre = "";

            foreach (DataRow fila in tabla.Rows)
            {
                nombre = fila["nombre"].ToString();
                int pos = nombre.IndexOf(queBusco);
                if (pos > -1)
                {
                    dgvAlumno.Rows.Add(fila["dni"].ToString(), fila["nombre"].ToString(), fila[""].ToString());
                }
            }
        }

        private void frmConsultarAlumnoParteNombre_Load(object sender, EventArgs e)
        {
            a = new clsAlumno();
            tabla = a.getAlumnos();
            b = new clsBarrio();
        }
    }
}
