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

        public void Conectar()
        {
            cnn = new SqlConnection(cadenaconexion);
            cnn.Open();
        }

        public void Desconectar()
        {
            cnn.Close();
        }
        public string Mensaje
        {
            get
            {
                return this.mensaje;
            }
        }

        public void IngresaProducto(Producto L)
        {
            string buscar = "select * from Libros where codigo =" + Convert.ToInt32(L.Codigo);
            SqlConnection connection = new SqlConnection(cadenaconexion);
            connection.Open();
            SqlCommand command = new SqlCommand(buscar, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            int contador = 0;
            int cant = 0;
            while (dataReader.Read())
            {
                contador = int.Parse(dataReader["codigo"].ToString());
                cant = int.Parse(dataReader["cantidadEx"].ToString());
   
            }
            dataReader.Close();

            MessageBox.Show("Se ha ingresado exitosamente el libro " + L.Codigo + " - " + L.Titulo);

            if (contador == L.Codigo)
            {
                string Actualizar = "update Libros set  precio =" + L.Precio + ", cantidadEx = " + (cant + L.CantidadEx) + " where codigo =" + L.Codigo;
                command = new SqlCommand(Actualizar, connection);
                command.ExecuteNonQuery();

            }
            else
            {
                string insertNewBook = "insert into Libros values ( " + L.Codigo + ",'" + L.Titulo + "','" +
                    L.Autor + "','" + L.Editorial + "','" + L.Precio + "','" + L.Ubicacion + "','" + L.CantidadEx + "')";

                command = new SqlCommand(insertNewBook, connection);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }


        public Producto BuscarCodigo(string codigo)
        {
            Producto P;
            try
            {
                P = new Producto();
                if (codigo == "")
                {
                    return P;
                }
                Conectar();

                string buscar = "select * from Libros where codigo =" + int.Parse(codigo);

                SqlCommand command = new SqlCommand(buscar, cnn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    P.Titulo = reader["titulo"].ToString();
                    P.Codigo = int.Parse(reader["codigo"].ToString());
                    P.Autor = reader["autor"].ToString();
                    P.Editorial = reader["editorial"].ToString();
                    P.Precio = double.Parse(reader["precio"].ToString());
                    P.Ubicacion = reader["ubicacion"].ToString();
                    P.CantidadEx = int.Parse(reader["cantidadEx"].ToString());
                }

                Desconectar();
                return P;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

    }
}
