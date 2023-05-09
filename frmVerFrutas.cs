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
    public partial class frmVerFrutas : Form
    {
        clsFruta f;
        public frmVerFrutas()
        {
            InitializeComponent();
        }

        private void frmVerFrutas_Load(object sender, EventArgs e)
        {
            f = new clsFruta();
            f.verTodo(dgvFruta);
        }
    }
}
