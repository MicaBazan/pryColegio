using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace pryColegio
{
    class clsGustan
    {
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


    }
}
