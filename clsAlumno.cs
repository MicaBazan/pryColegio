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
    class clsAlumno
    {
        clsBarrio b = new clsBarrio();

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

        public void buscar()
        {
            DataRow fila = tabla.Rows.Find(dni);

            if (fila == null)
            {
                nombre = "";
                foto = "";
            }
            else
            {
                nombre = fila["nombre"].ToString();
                foto = fila["foto"].ToString();
            }
        }

        public void ver(DataGridView dgv, string busco)
        {
            dgv.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {

                string sexo = "FEMENINO";

                if (fila["sexo"].ToString() == "M")
                {
                    sexo = "MASCULINO";
                }

                string nb = b.buscar(Convert.ToInt32(fila["barrio"]));

                int pos = fila["nombre"].ToString().IndexOf(busco);

                if (pos > -1)
                {
                    dgv.Rows.Add(fila["dni"], fila["nombre"], sexo, nb);
                }
            }
        }

        public void verTodo(DataGridView dgv)
        {
            dgv.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                string sexo = "FEMENINO";

                if (fila["sexo"].ToString() == "M")
                {
                    sexo = "MASCULINO";
                }

                string nb = b.buscar(Convert.ToInt32(fila["barrio"]));

                dgv.Rows.Add(fila["dni"], fila["nombre"], sexo, nb);
            }
        }

        public string buscar(int dni)
        {
            DataRow fila = tabla.Rows.Find(dni);
            return fila["nombre"].ToString();
        }
    }
}