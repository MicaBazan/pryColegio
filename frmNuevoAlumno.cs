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
        public frmNuevoAlumno()
        {
            InitializeComponent();
        }

        private void frmNuevoAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                listarBarrio();
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
    }
}
