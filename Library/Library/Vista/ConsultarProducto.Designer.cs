namespace Library.Vista
{
    partial class ConsultarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarProducto));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblIngresarProducto = new System.Windows.Forms.Label();
            this.SlideAutor = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.SlideCodigo = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngresarDato = new Bunifu.Framework.UI.BunifuMetroTextbox();
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
            this.pnlTitulo.TabIndex = 18;
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
            this.lblIngresarProducto.Size = new System.Drawing.Size(249, 18);
            this.lblIngresarProducto.TabIndex = 1;
            this.lblIngresarProducto.Text = "C O N S U L T A R   P R O D U C T O";
            // 
            // SlideAutor
            // 
            this.SlideAutor.BackColor = System.Drawing.Color.Transparent;
            this.SlideAutor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SlideAutor.BackgroundImage")));
            this.SlideAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlideAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlideAutor.Location = new System.Drawing.Point(288, 129);
            this.SlideAutor.Name = "SlideAutor";
            this.SlideAutor.OffColor = System.Drawing.Color.Gray;
            this.SlideAutor.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.SlideAutor.Size = new System.Drawing.Size(35, 20);
            this.SlideAutor.TabIndex = 19;
            this.SlideAutor.Value = false;
            // 
            // SlideCodigo
            // 
            this.SlideCodigo.BackColor = System.Drawing.Color.Transparent;
            this.SlideCodigo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SlideCodigo.BackgroundImage")));
            this.SlideCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlideCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlideCodigo.Location = new System.Drawing.Point(565, 129);
            this.SlideCodigo.Name = "SlideCodigo";
            this.SlideCodigo.OffColor = System.Drawing.Color.Gray;
            this.SlideCodigo.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.SlideCodigo.Size = new System.Drawing.Size(35, 20);
            this.SlideCodigo.TabIndex = 20;
            this.SlideCodigo.Value = false;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblAutor.Location = new System.Drawing.Point(234, 93);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(154, 18);
            this.lblAutor.TabIndex = 31;
            this.lblAutor.Text = "BUSCAR POR AUTOR";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.Location = new System.Drawing.Point(501, 93);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(171, 18);
            this.lblCodigo.TabIndex = 32;
            this.lblCodigo.Text = "BUSCAR POR CÓDIGO";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 190);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(181, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "I N G R E S E  E L  D A T O";
            // 
            // txtIngresarDato
            // 
            this.txtIngresarDato.BorderColorFocused = System.Drawing.Color.Lavender;
            this.txtIngresarDato.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIngresarDato.BorderColorMouseHover = System.Drawing.Color.Lavender;
            this.txtIngresarDato.BorderThickness = 3;
            this.txtIngresarDato.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIngresarDato.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIngresarDato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIngresarDato.isPassword = false;
            this.txtIngresarDato.Location = new System.Drawing.Point(237, 212);
            this.txtIngresarDato.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngresarDato.Name = "txtIngresarDato";
            this.txtIngresarDato.Size = new System.Drawing.Size(435, 44);
            this.txtIngresarDato.TabIndex = 33;
            this.txtIngresarDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.SkyBlue;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageActive = null;
            this.btnOk.Location = new System.Drawing.Point(393, 307);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(97, 47);
            this.btnOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnOk.TabIndex = 35;
            this.btnOk.TabStop = false;
            this.btnOk.Zoom = 10;
            // 
            // ConsultarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 411);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIngresarDato);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.SlideCodigo);
            this.Controls.Add(this.SlideAutor);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarProducto";
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
        private Bunifu.Framework.UI.BunifuiOSSwitch SlideCodigo;
        private Bunifu.Framework.UI.BunifuiOSSwitch SlideAutor;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtIngresarDato;
        private Bunifu.Framework.UI.BunifuImageButton btnOk;
    }
}