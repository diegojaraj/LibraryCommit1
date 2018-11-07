using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Vista
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void btnIngresarProducto_Click(object sender, EventArgs e)
        {
            IngresarProducto ingresar = new IngresarProducto();
            ingresar.Show();
        }

        private void btnConsultarProducto_Click(object sender, EventArgs e)
        {
            ConsultarProducto consultar = new ConsultarProducto();
            consultar.Show();
        }

        private void btnIngresarVenta_Click(object sender, EventArgs e)
        {
            IngresarVenta venta = new IngresarVenta();
            venta.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            creditos.Show();
        }
    }
}
