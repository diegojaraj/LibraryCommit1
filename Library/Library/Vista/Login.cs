using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Vista;
using Library.Modelo;
using System.Data.SqlClient;
using System.Configuration;

namespace Library
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void acceso()
        {
            Usuarios usuarioObjeto = new Usuarios();
            usuarioObjeto.Usuario = this.txtUsuario.Text;
            usuarioObjeto.Contraseña = this.txtContraseña.Text;


            if (usuarioObjeto.Buscar() == true)
            {
                MessageBox.Show(usuarioObjeto.Mensaje, "Login");
                Inventario inventario = new Inventario();
                inventario.Show();
                inventario.lblNombreAqui.Text = txtUsuario.Text;
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
            else
            {
                MessageBox.Show(usuarioObjeto.Mensaje, "Error");
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                txtUsuario.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //FormTransiton.ShowAsyc(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtContraseña.Focus();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            acceso();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                acceso();
            }
        }
    }
}
