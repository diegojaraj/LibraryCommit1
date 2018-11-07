namespace Library.Vista
{
    partial class IngresarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarVenta));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblIngresarProducto = new System.Windows.Forms.Label();
            this.btnOk = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblIngreseCodigo = new System.Windows.Forms.Label();
            this.txtIngreseCodigo = new Bunifu.Framework.UI.BunifuMetroTextbox();
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
            this.lblIngresarProducto.Size = new System.Drawing.Size(184, 18);
            this.lblIngresarProducto.TabIndex = 1;
            this.lblIngresarProducto.Text = "I N G R E S A R   V E N T A";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.SkyBlue;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageActive = null;
            this.btnOk.Location = new System.Drawing.Point(403, 288);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(97, 47);
            this.btnOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnOk.TabIndex = 38;
            this.btnOk.TabStop = false;
            this.btnOk.Zoom = 10;
            // 
            // lblIngreseCodigo
            // 
            this.lblIngreseCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIngreseCodigo.AutoSize = true;
            this.lblIngreseCodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseCodigo.Location = new System.Drawing.Point(243, 166);
            this.lblIngreseCodigo.Name = "lblIngreseCodigo";
            this.lblIngreseCodigo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIngreseCodigo.Size = new System.Drawing.Size(222, 18);
            this.lblIngreseCodigo.TabIndex = 37;
            this.lblIngreseCodigo.Text = "I N G R E S E   E L   C Ó D I G O";
            // 
            // txtIngreseCodigo
            // 
            this.txtIngreseCodigo.BorderColorFocused = System.Drawing.Color.Lavender;
            this.txtIngreseCodigo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIngreseCodigo.BorderColorMouseHover = System.Drawing.Color.Lavender;
            this.txtIngreseCodigo.BorderThickness = 3;
            this.txtIngreseCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIngreseCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIngreseCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIngreseCodigo.isPassword = false;
            this.txtIngreseCodigo.Location = new System.Drawing.Point(243, 188);
            this.txtIngreseCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngreseCodigo.Name = "txtIngreseCodigo";
            this.txtIngreseCodigo.Size = new System.Drawing.Size(435, 44);
            this.txtIngreseCodigo.TabIndex = 36;
            this.txtIngreseCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // IngresarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 411);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblIngreseCodigo);
            this.Controls.Add(this.txtIngreseCodigo);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IngresarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarVenta";
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
        private Bunifu.Framework.UI.BunifuImageButton btnOk;
        private System.Windows.Forms.Label lblIngreseCodigo;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtIngreseCodigo;
    }
}