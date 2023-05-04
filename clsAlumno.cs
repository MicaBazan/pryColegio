using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace pryColegio
{
    class clsAlumno
    {
        private string cadena;
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        private int dni;
        private string nombre;
        private string sexo;
        private string foto;
        private int barrio;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public int Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }

        public clsAlumno()
        {
            cadena = clsConexion.getCadena();

            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();
            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Alumnos";
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] vector = new DataColumn[1];
            vector[0] = tabla.Columns["dni"];
            tabla.PrimaryKey = vector;
        }

        public DataTable getAlumnos()
        {
            return tabla;
        }

        public void grabar()
        {
            DataRow filaBusca = tabla.Rows.Find(dni);

            if (filaBusca is null)
            {
                DataRow fila = tabla.NewRow();
                fila["dni"] = dni;
                fila["nombre"] = nombre;
                fila["sexo"] = sexo;
                fila["foto"] = foto;
                fila["barrio"] = barrio;
                tabla.Rows.Add(fila);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                adaptador.Update(tabla);
            }
            else
            {
                dni = 0;
                nombre = "";
                sexo = "";
                foto = "";
                barrio = 0;
            }
        }
    }
}
