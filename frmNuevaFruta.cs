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
    public partial class frmNuevaFruta : Form
    {
        public frmNuevaFruta()
        {
            InitializeComponent();
        }

        clsFruta fruta = new clsFruta();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                fruta.Fruta = Convert.ToInt32(txtCodigo.Text);
                fruta.Nombre = txtNombre.Text;

                fruta.grabar();

                if (fruta.Fruta == 0)
                {
                    MessageBox.Show("FRUTA REPETIDA, NO SE PUDO GRABAR", "ERROR");
                }
                else
                {
                    MessageBox.Show("FRUTA GUARDADA CON EXITO");
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
