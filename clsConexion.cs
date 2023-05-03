using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryColegio
{
    class clsConexion
    {
        public static string getCadena()
        {
            string cadena = "provider=microsoft.jet.oledb.4.0;data source=CLIMA.mdb";
            return cadena;
        }
    }
}
