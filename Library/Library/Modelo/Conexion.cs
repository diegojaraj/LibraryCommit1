using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.Modelo
{
    class Conexion
    {
        public string cadenaconexion;
        protected string sql;
        protected int resultado;
        protected SqlConnection cnn;
        protected SqlCommand comandosql;
        protected string mensaje;

        public Conexion()
        {
            this.cadenaconexion = ("server = DESKTOP-O456S9B\\SQLEXPRESS;Initial Catalog = Library; integrated security = true");
            this.cnn = new SqlConnection(this.cadenaconexion);
        }
        public string Mensaje
        {
            get
            {
                return this.mensaje;
            }
        }
    }
}
