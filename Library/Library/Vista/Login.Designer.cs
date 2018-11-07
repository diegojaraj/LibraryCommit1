namespace Library
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnOk = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblInventario = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FormTransiton = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.SkyBlue;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageActive = null;
            this.btnOk.Location = new System.Drawing.Point(408, 317);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(97, 47);
            this.btnOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnOk.TabIndex = 21;
            this.btnOk.TabStop = false;
            this.btnOk.Zoom = 10;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblContraseña.Location = new System.Drawing.Point(262, 211);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(144, 18);
            this.lblContraseña.TabIndex = 20;
            this.lblContraseña.Text = "C O N T R A S E Ñ A";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderColorFocused = System.Drawing.Color.Lavender;
            this.txtContraseña.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContraseña.BorderColorMouseHover = System.Drawing.Color.Lavender;
            this.txtContraseña.BorderThickness = 3;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContraseña.isPassword = true;
            this.txtContraseña.Location = new System.Drawing.Point(265, 233);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(370, 44);
            this.txtContraseña.TabIndex = 19;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(262, 129);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(97, 18);
            this.lblUsuario.TabIndex = 18;
            this.lblUsuario.Text = "U S U A R I O";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderColorFocused = System.Drawing.Color.Lavender;
            this.txtUsuario.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.BorderColorMouseHover = System.Drawing.Color.Lavender;
            this.txtUsuario.BorderThickness = 3;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.isPassword = false;
            this.txtUsuario.Location = new System.Drawing.Point(265, 151);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(370, 44);
            this.txtUsuario.TabIndex = 17;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblBienvenido.Location = new System.Drawing.Point(729, 56);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(134, 18);
            this.lblBienvenido.TabIndex = 15;
            this.lblBienvenido.Text = "B I E N V E N I D O";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlTitulo.Controls.Add(this.btnCancelar);
            this.pnlTitulo.Controls.Add(this.lblInventario);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(875, 44);
            this.pnlTitulo.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageActive = null;
            this.btnCancelar.Location = new System.Drawing.Point(831, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(41, 37);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Zoom = 10;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblInventario.Location = new System.Drawing.Point(12, 13);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(233, 18);
            this.lblInventario.TabIndex = 1;
            this.lblInventario.Text = "I N V E N T A R I O   L I B R E R I A";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Aceptar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(97, 480);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(161, 63);
            this.bunifuFlatButton1.TabIndex = 22;
            this.bunifuFlatButton1.Text = "Aceptar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormTransiton
            // 
            this.FormTransiton.Delay = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 411);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnOk;
        private System.Windows.Forms.Label lblContraseña;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsuario;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblInventario;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuImageButton btnCancelar;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FormTransiton;
    }
}

