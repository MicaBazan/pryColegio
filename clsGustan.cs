using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryColegio
{
    class clsGustan
    {
        clsFruta f = new clsFruta();

        private string cadena;
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        private int dni;
        private int fruta;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public int Fruta
        {
            get { return fruta; }
            set { fruta = value; }
        }

        public clsGustan()
        {
            cadena = clsConexion.getCadena();

            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();
            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "LeGustan";
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);
        }

        public DataTable getGustan()
        {
            return tabla;
        }

        public void grabar()
        {
            DataRow fila = tabla.NewRow();
            fila["dni"] = dni;
            fila["fruta"] = fruta;
            tabla.Rows.Add(fila);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
            adaptador.Update(tabla);
        }

        public void ver(DataGridView dgv, int busco)
        {
            dgv.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                if (busco == Convert.ToInt32(fila["dni"]))
                {
                    string fruta = f.buscar(Convert.ToInt32(fila["fruta"]));

                    dgv.Rows.Add(fruta);
                }
 
            }
        }

        public void verNo(DataGridView dgv, int busco)
        {
            dgv.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                if (busco == Convert.ToInt32(fila["dni"]))
                {
                    string fruta = f.buscar(Convert.ToInt32(fila["fruta"]));

                    dgv.Rows.Add(fruta);
                }

            }
        }

        public void sumar(DataGridView dgv, int fruta)
        {
            int i = 0;
            dgv.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                if (fruta == Convert.ToInt32(fila["fruta"]))
                {
                    i = i + 1;
                }
            }

            string fru = f.buscar(Convert.ToInt32(fruta));
            dgv.Rows.Add(fru, i);
        }

    }
}
