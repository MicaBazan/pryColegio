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
    public partial class frmVerFrutasyCantidadTotalDeAlumnoXFruta : Form
    {
        clsGustan g;
        clsFruta f;
        public frmVerFrutasyCantidadTotalDeAlumnoXFruta()
        {
            InitializeComponent();
        }

        private void frmVerFrutasyCantidadTotalDeAlumnoXFruta_Load(object sender, EventArgs e)
        {
            g = new clsGustan();
            f = new clsFruta();

            cbFruta.DisplayMember = "nombre";
            cbFruta.ValueMember = "fruta";
            cbFruta.DataSource = f.getFrutas();

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int fru = Convert.ToInt32(cbFruta.SelectedValue);
            g.sumar(dgvFruta, fru);
        }
    }
}
