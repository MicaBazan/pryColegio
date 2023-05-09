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
    class clsFruta
    {
        private string cadena;
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        private int fruta;
        private string nombre;

        public int Fruta
        {
            get { return fruta; }
            set { fruta = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public clsFruta()
        {
            cadena = clsConexion.getCadena();

            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();
            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Frutas";
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] vector = new DataColumn[1];
            vector[0] = tabla.Columns["fruta"];
            tabla.PrimaryKey = vector;
        }

        public DataTable getFrutas()
        {
            return tabla;
        }

        public void grabar()
        {
            DataRow filaBusca = tabla.Rows.Find(fruta);

            if (filaBusca is null)
            {
                DataRow fila = tabla.NewRow();
                fila["fruta"] = fruta;
                fila["nombre"] = nombre;
                tabla.Rows.Add(fila);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                adaptador.Update(tabla);
            }
            else
            {
                fruta = 0;
                nombre = "";
            }
        }

        public void verTodo(DataGridView dgv)
        {
            dgv.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                dgv.Rows.Add(fila["fruta"], fila["nombre"]);
            }
        }

        public string buscar(int fruta)
        {
            DataRow fila = tabla.Rows.Find(fruta);
            return fila["nombre"].ToString();
        }

        
    }
}
