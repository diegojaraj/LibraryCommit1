namespace Library.Vista
{
    partial class Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnIngresarProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnConsultarProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIngresarVenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblNombreAqui = new System.Windows.Forms.Label();
            this.btnCreditos = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblUsuarioLogeado = new System.Windows.Forms.Label();
            this.tblOperacionRealizada = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.pnlTitulo.TabIndex = 17;
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
            this.btnCancelar.TabIndex = 29;
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
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(35, 143);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(334, 18);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "SELECCIONE LA OPCIÓN DE SU PREFERENCIA:";
            // 
            // btnIngresarProducto
            // 
            this.btnIngresarProducto.Activecolor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresarProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresarProducto.BorderRadius = 0;
            this.btnIngresarProducto.ButtonText = "&INGRESAR PRODUCTO";
            this.btnIngresarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresarProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnIngresarProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIngresarProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnIngresarProducto.Iconimage")));
            this.btnIngresarProducto.Iconimage_right = null;
            this.btnIngresarProducto.Iconimage_right_Selected = null;
            this.btnIngresarProducto.Iconimage_Selected = null;
            this.btnIngresarProducto.IconMarginLeft = 0;
            this.btnIngresarProducto.IconMarginRight = 0;
            this.btnIngresarProducto.IconRightVisible = true;
            this.btnIngresarProducto.IconRightZoom = 0D;
            this.btnIngresarProducto.IconVisible = true;
            this.btnIngresarProducto.IconZoom = 90D;
            this.btnIngresarProducto.IsTab = false;
            this.btnIngresarProducto.Location = new System.Drawing.Point(38, 256);
            this.btnIngresarProducto.Name = "btnIngresarProducto";
            this.btnIngresarProducto.Normalcolor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresarProducto.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btnIngresarProducto.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnIngresarProducto.selected = false;
            this.btnIngresarProducto.Size = new System.Drawing.Size(241, 48);
            this.btnIngresarProducto.TabIndex = 19;
            this.btnIngresarProducto.Text = "&INGRESAR PRODUCTO";
            this.btnIngresarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresarProducto.Textcolor = System.Drawing.Color.Black;
            this.btnIngresarProducto.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnIngresarProducto.Click += new System.EventHandler(this.btnIngresarProducto_Click);
            // 
            // btnConsultarProducto
            // 
            this.btnConsultarProducto.Activecolor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsultarProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsultarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultarProducto.BorderRadius = 0;
            this.btnConsultarProducto.ButtonText = "&CONSULTAR PRODUCTO";
            this.btnConsultarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnConsultarProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConsultarProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConsultarProducto.Iconimage")));
            this.btnConsultarProducto.Iconimage_right = null;
            this.btnConsultarProducto.Iconimage_right_Selected = null;
            this.btnConsultarProducto.Iconimage_Selected = null;
            this.btnConsultarProducto.IconMarginLeft = 0;
            this.btnConsultarProducto.IconMarginRight = 0;
            this.btnConsultarProducto.IconRightVisible = true;
            this.btnConsultarProducto.IconRightZoom = 0D;
            this.btnConsultarProducto.IconVisible = true;
            this.btnConsultarProducto.IconZoom = 90D;
            this.btnConsultarProducto.IsTab = false;
            this.btnConsultarProducto.Location = new System.Drawing.Point(314, 256);
            this.btnConsultarProducto.Name = "btnConsultarProducto";
            this.btnConsultarProducto.Normalcolor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsultarProducto.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btnConsultarProducto.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnConsultarProducto.selected = false;
            this.btnConsultarProducto.Size = new System.Drawing.Size(241, 48);
            this.btnConsultarProducto.TabIndex = 20;
            this.btnConsultarProducto.Text = "&CONSULTAR PRODUCTO";
            this.btnConsultarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarProducto.Textcolor = System.Drawing.Color.Black;
            this.btnConsultarProducto.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnConsultarProducto.Click += new System.EventHandler(this.btnConsultarProducto_Click);
            // 
            // btnIngresarVenta
            // 
            this.btnIngresarVenta.Activecolor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresarVenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresarVenta.BorderRadius = 0;
            this.btnIngresarVenta.ButtonText = "INGRESAR &VENTA";
            this.btnIngresarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresarVenta.DisabledColor = System.Drawing.Color.Gray;
            this.btnIngresarVenta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIngresarVenta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnIngresarVenta.Iconimage")));
            this.btnIngresarVenta.Iconimage_right = null;
            this.btnIngresarVenta.Iconimage_right_Selected = null;
            this.btnIngresarVenta.Iconimage_Selected = null;
            this.btnIngresarVenta.IconMarginLeft = 0;
            this.btnIngresarVenta.IconMarginRight = 0;
            this.btnIngresarVenta.IconRightVisible = true;
            this.btnIngresarVenta.IconRightZoom = 0D;
            this.btnIngresarVenta.IconVisible = true;
            this.btnIngresarVenta.IconZoom = 90D;
            this.btnIngresarVenta.IsTab = false;
            this.btnIngresarVenta.Location = new System.Drawing.Point(595, 256);
            this.btnIngresarVenta.Name = "btnIngresarVenta";
            this.btnIngresarVenta.Normalcolor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresarVenta.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btnIngresarVenta.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnIngresarVenta.selected = false;
            this.btnIngresarVenta.Size = new System.Drawing.Size(241, 48);
            this.btnIngresarVenta.TabIndex = 21;
            this.btnIngresarVenta.Text = "INGRESAR &VENTA";
            this.btnIngresarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresarVenta.Textcolor = System.Drawing.Color.Black;
            this.btnIngresarVenta.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnIngresarVenta.Click += new System.EventHandler(this.btnIngresarVenta_Click);
            // 
            // lblNombreAqui
            // 
            this.lblNombreAqui.AutoSize = true;
            this.lblNombreAqui.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNombreAqui.Location = new System.Drawing.Point(769, 47);
            this.lblNombreAqui.Name = "lblNombreAqui";
            this.lblNombreAqui.Size = new System.Drawing.Size(103, 18);
            this.lblNombreAqui.TabIndex = 22;
            this.lblNombreAqui.Text = "nombre aquí";
            // 
            // btnCreditos
            // 
            this.btnCreditos.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCreditos.color = System.Drawing.Color.SkyBlue;
            this.btnCreditos.colorActive = System.Drawing.Color.SkyBlue;
            this.btnCreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditos.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCreditos.ForeColor = System.Drawing.Color.White;
            this.btnCreditos.Image = null;
            this.btnCreditos.ImagePosition = 20;
            this.btnCreditos.ImageZoom = 50;
            this.btnCreditos.LabelPosition = 30;
            this.btnCreditos.LabelText = "CREDITOS";
            this.btnCreditos.Location = new System.Drawing.Point(748, 362);
            this.btnCreditos.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(112, 34);
            this.btnCreditos.TabIndex = 23;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // lblUsuarioLogeado
            // 
            this.lblUsuarioLogeado.AutoSize = true;
            this.lblUsuarioLogeado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioLogeado.Location = new System.Drawing.Point(606, 47);
            this.lblUsuarioLogeado.Name = "lblUsuarioLogeado";
            this.lblUsuarioLogeado.Size = new System.Drawing.Size(157, 18);
            this.lblUsuarioLogeado.TabIndex = 24;
            this.lblUsuarioLogeado.Text = "USUARIO LOGEADO:";
            // 
            // tblOperacionRealizada
            // 
            this.tblOperacionRealizada.AutoSize = true;
            this.tblOperacionRealizada.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tblOperacionRealizada.Location = new System.Drawing.Point(530, 65);
            this.tblOperacionRealizada.Name = "tblOperacionRealizada";
            this.tblOperacionRealizada.Size = new System.Drawing.Size(342, 18);
            this.tblOperacionRealizada.TabIndex = 25;
            this.tblOperacionRealizada.Text = "¡SU OPERACIÓN SE REALIZO CORRECTAMENTE!";
            this.tblOperacionRealizada.Visible = false;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 411);
            this.Controls.Add(this.tblOperacionRealizada);
            this.Controls.Add(this.lblUsuarioLogeado);
            this.Controls.Add(this.btnCreditos);
            this.Controls.Add(this.lblNombreAqui);
            this.Controls.Add(this.btnIngresarVenta);
            this.Controls.Add(this.btnConsultarProducto);
            this.Controls.Add(this.btnIngresarProducto);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblInventario;
        private Bunifu.Framework.UI.BunifuFlatButton btnIngresarVenta;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultarProducto;
        private Bunifu.Framework.UI.BunifuFlatButton btnIngresarProducto;
        private Bunifu.Framework.UI.BunifuImageButton btnCancelar;
        private Bunifu.Framework.UI.BunifuTileButton btnCreditos;
        public System.Windows.Forms.Label lblNombreAqui;
        public System.Windows.Forms.Label lblUsuarioLogeado;
        public System.Windows.Forms.Label tblOperacionRealizada;
    }
}