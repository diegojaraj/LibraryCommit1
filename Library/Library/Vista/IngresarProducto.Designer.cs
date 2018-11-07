namespace Library.Vista
{
    partial class IngresarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarProducto));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblIngresarProducto = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblNTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtTitulo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUbicacion = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtEditorial = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtAutor = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCodigo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblCantidadAIngresar = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnOk = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).BeginInit();
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
            this.pnlTitulo.Controls.Add(this.lblIngresarProducto);
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
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Zoom = 10;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIngresarProducto
            // 
            this.lblIngresarProducto.AutoSize = true;
            this.lblIngresarProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblIngresarProducto.Location = new System.Drawing.Point(12, 13);
            this.lblIngresarProducto.Name = "lblIngresarProducto";
            this.lblIngresarProducto.Size = new System.Drawing.Size(231, 18);
            this.lblIngresarProducto.TabIndex = 1;
            this.lblIngresarProducto.Text = "I N G R E S A R   P R O D U C T O";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(59, 238);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUbicacion.Size = new System.Drawing.Size(126, 18);
            this.lblUbicacion.TabIndex = 31;
            this.lblUbicacion.Text = "U B I C A C I Ó N";
            // 
            // lblEditorial
            // 
            this.lblEditorial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.Location = new System.Drawing.Point(463, 160);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEditorial.Size = new System.Drawing.Size(113, 18);
            this.lblEditorial.TabIndex = 30;
            this.lblEditorial.Text = "E D I T O R I A L";
            // 
            // lblAutor
            // 
            this.lblAutor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(59, 160);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAutor.Size = new System.Drawing.Size(73, 18);
            this.lblAutor.TabIndex = 29;
            this.lblAutor.Text = "A U T O R";
            // 
            // lblNTitulo
            // 
            this.lblNTitulo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNTitulo.AutoSize = true;
            this.lblNTitulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTitulo.Location = new System.Drawing.Point(463, 77);
            this.lblNTitulo.Name = "lblNTitulo";
            this.lblNTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNTitulo.Size = new System.Drawing.Size(74, 18);
            this.lblNTitulo.TabIndex = 28;
            this.lblNTitulo.Text = "T I T U L O";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(59, 77);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCodigo.Size = new System.Drawing.Size(94, 18);
            this.lblCodigo.TabIndex = 27;
            this.lblCodigo.Text = "C Ó D I G O";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderColorFocused = System.Drawing.Color.Lavender;
            this.txtTitulo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTitulo.BorderColorMouseHover = System.Drawing.Color.Lavender;
            this.txtTitulo.BorderThickness = 3;
            this.txtTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTitulo.isPassword = false;
            this.txtTitulo.Location = new System.Drawing.Point(463, 99);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(370, 44);
            this.txtTitulo.TabIndex = 23;
            this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.BorderColorFocused = System.Drawing.Color.Lavender;
            this.txtUbicacion.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUbicacion.BorderColorMouseHover = System.Drawing.Color.Lavender;
            this.txtUbicacion.BorderThickness = 3;
            this.txtUbicacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUbicacion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUbicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUbicacion.isPassword = false;
            this.txtUbicacion.Location = new System.Drawing.Point(59, 260);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(370, 44);
            this.txtUbicacion.TabIndex = 26;
            this.txtUbicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEditorial
            // 
            this.txtEditorial.BorderColorFocused = System.Drawing.Color.Lavender;
            this.txtEditorial.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEditorial.BorderColorMouseHover = System.Drawing.Color.Lavender;
            this.txtEditorial.BorderThickness = 3;
            this.txtEditorial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditorial.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEditorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEditorial.isPassword = false;
            this.txtEditorial.Location = new System.Drawing.Point(463, 182);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(370, 44);
            this.txtEditorial.TabIndex = 25;
            this.txtEditorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAutor
            // 
            this.txtAutor.BorderColorFocused = System.Drawing.Color.Lavender;
            this.txtAutor.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAutor.BorderColorMouseHover = System.Drawing.Color.Lavender;
            this.txtAutor.BorderThickness = 3;
            this.txtAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAutor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAutor.isPassword = false;
            this.txtAutor.Location = new System.Drawing.Point(59, 182);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(370, 44);
            this.txtAutor.TabIndex = 24;
            this.txtAutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderColorFocused = System.Drawing.Color.Lavender;
            this.txtCodigo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigo.BorderColorMouseHover = System.Drawing.Color.Lavender;
            this.txtCodigo.BorderThickness = 3;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigo.isPassword = false;
            this.txtCodigo.Location = new System.Drawing.Point(59, 99);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(370, 44);
            this.txtCodigo.TabIndex = 22;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblCantidadAIngresar
            // 
            this.lblCantidadAIngresar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCantidadAIngresar.AutoSize = true;
            this.lblCantidadAIngresar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadAIngresar.Location = new System.Drawing.Point(463, 238);
            this.lblCantidadAIngresar.Name = "lblCantidadAIngresar";
            this.lblCantidadAIngresar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCantidadAIngresar.Size = new System.Drawing.Size(241, 18);
            this.lblCantidadAIngresar.TabIndex = 33;
            this.lblCantidadAIngresar.Text = "C A N T I D A D  A  I N G R E S A R";
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Lavender;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Lavender;
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(463, 260);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(370, 44);
            this.bunifuMetroTextbox1.TabIndex = 32;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.SkyBlue;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageActive = null;
            this.btnOk.Location = new System.Drawing.Point(403, 335);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(97, 47);
            this.btnOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnOk.TabIndex = 34;
            this.btnOk.TabStop = false;
            this.btnOk.Zoom = 10;
            // 
            // IngresarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 411);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblCantidadAIngresar);
            this.Controls.Add(this.bunifuMetroTextbox1);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblNTitulo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IngresarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarProducto";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlTitulo;
        private Bunifu.Framework.UI.BunifuImageButton btnCancelar;
        private System.Windows.Forms.Label lblIngresarProducto;
        private System.Windows.Forms.Label lblCantidadAIngresar;
        public Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblNTitulo;
        private System.Windows.Forms.Label lblCodigo;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtTitulo;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtUbicacion;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtEditorial;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtAutor;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtCodigo;
        private Bunifu.Framework.UI.BunifuImageButton btnOk;
    }
}