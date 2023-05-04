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
    public partial class frmNuevoAlumno : Form
    {
        clsBarrio barrio;
        clsAlumno alumno = new clsAlumno();
        public frmNuevoAlumno()
        {
            InitializeComponent();
        }

        private void frmNuevoAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                listarBarrio();
                rbFemenino.Checked = true;
            }
            catch
            {
                MessageBox.Show("PROBLEMAS CON LA BASE DE DATOS", "ERROR");
                this.Close();
            }
        }

        private void listarBarrio()
        {
            barrio = new clsBarrio();

            cbBarrio.DisplayMember = "nombre";
            cbBarrio.ValueMember = "barrio";
            cbBarrio.DataSource = barrio.getBarrios();
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            ofdFoto.ShowDialog();
            txtURL.Text = ofdFoto.SafeFileName;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string sexo;
                
                alumno.Dni = Convert.ToInt32(txtDni.Text);
                alumno.Nombre = txtNombre.Text;

                if (rbFemenino.Checked)
                {
                    sexo = "F";
                }
                else
                {
                    sexo = "M";
                }

                alumno.Sexo = sexo;
                alumno.Foto = txtURL.Text;
                alumno.Barrio = Convert.ToInt32(cbBarrio.SelectedValue);


                alumno.grabar();

                if (alumno.Dni == 0)
                {
                    MessageBox.Show("ALUMNO REPETIDO, NO SE PUDO GRABAR", "ERROR");
                }
                else
                {
                    MessageBox.Show("ALUMNO GUARDADO CON EXITO");
                    txtDni.Text = "";
                    txtNombre.Text = "";
                    txtURL.Text = "";
                    cbBarrio.Text = "";

                    txtDni.Focus();
                }
            }
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO....", "ERROR");
            }
        }
    }
}
