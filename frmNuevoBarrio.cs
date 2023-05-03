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
    public partial class frmNuevoBarrio : Form
    {
        public frmNuevoBarrio()
        {
            InitializeComponent();
        }

        clsBarrio barrio = new clsBarrio();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                barrio.Barrio = Convert.ToInt32(txtCodigo.Text);
                barrio.Nombre = txtNombre.Text;

                barrio.grabar();

                if(barrio.Barrio == 0)
                {
                    MessageBox.Show("BARRIO REPETIDO, NO SE PUDO GRABAR", "ERROR");
                }
                else
                {
                    MessageBox.Show("BARRIO GUARDADO CON EXITO", "ERROR");
                    txtCodigo.Text = "";
                    txtNombre.Text = "";

                    txtCodigo.Focus();
                }
            }
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO....", "ERROR");
            }
        }
    }
}
