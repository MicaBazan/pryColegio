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



        }
    }
}
