using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Modelo;

namespace Library.Vista
{
    public partial class IngresarProducto : Form
    {
        Producto producto;
        public IngresarProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            var a = new MyLibrary.Validacion();
            a.ValidaNumero(e);

            if (e.KeyChar == 13)
            {
                txtCantidadEx.Focus();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            var a = new MyLibrary.Validacion();
            a.ValidaPUntoFlo(e);
        }

        private void txtCantidadEx_KeyPress(object sender, KeyPressEventArgs e)
        {
            var a = new MyLibrary.Validacion();
            a.ValidaNumero(e);

        }

        public void IngresarLibro()
        {
            if (txtCodigo.Text != "" && txtTitulo.Text != "" && txtAutor.Text != "" &&
                txtEditorial.Text != "" && txtPrecio.Text != "" && txtUbicacion.Text != "" && txtCantidadEx.Text != "")
            {
                var L = new Producto();

                L.Codigo = Convert.ToInt32(txtCodigo.Text);
                L.Titulo = txtTitulo.Text;
                L.Autor = txtAutor.Text;
                L.Editorial = txtEditorial.Text;
                L.Precio = Convert.ToDouble(txtPrecio.Text);
                L.Ubicacion = txtUbicacion.Text;
                L.CantidadEx = int.Parse(txtCantidadEx.Text);
                var c = new Conexion();
                c.IngresaProducto(L);
                txtCodigo.Text = "";
                txtTitulo.Text = "";
                txtAutor.Text = "";
                txtEditorial.Text = "";
                txtPrecio.Text = "";
                txtUbicacion.Text = "";
                txtCantidadEx.Text = "";

                Inventario inventario = new Inventario();
                inventario.Show();
                Login login = new Login();
                inventario.lblNombreAqui.Visible = false;
                inventario.lblUsuarioLogeado.Visible = false;
                inventario.tblOperacionRealizada.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            IngresarLibro();
        }

        private void txtCantidadEx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                IngresarLibro();
            }
            
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                IngresarLibro();
            }
        }

        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                IngresarLibro();
            }
        }

        private void txtEditorial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                IngresarLibro();
            }
        }

        private void txtUbicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                IngresarLibro();
            }
        }

        private void txtPrecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                IngresarLibro();
            }
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void txtCodigo_OnValueChanged(object sender, EventArgs e)
        {
            var c = new Conexion();

            producto = new Producto();
            string w = txtCodigo.Text;
            producto = c.BuscarCodigo(w);
            txtTitulo.Text = producto.Titulo;
            txtAutor.Text = producto.Autor;
            txtEditorial.Text = producto.Editorial;
            txtPrecio.Text = Convert.ToString(producto.Precio);
            txtUbicacion.Text = producto.Ubicacion;
        }
    }
}
