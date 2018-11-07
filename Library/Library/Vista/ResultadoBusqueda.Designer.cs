namespace Library.Vista
{
    partial class ResultadoBusqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadoBusqueda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblInventario = new System.Windows.Forms.Label();
            this.dgvFactura = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
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
            this.pnlTitulo.TabIndex = 2;
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
            this.btnCancelar.TabIndex = 83;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Zoom = 10;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.Location = new System.Drawing.Point(12, 13);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(312, 18);
            this.lblInventario.TabIndex = 1;
            this.lblInventario.Text = "R E S U L T A D O   D E   L A   B U S Q U E D A";
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFactura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFactura.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TITULO,
            this.PRECIO,
            this.CANTIDAD,
            this.UBICACION});
            this.dgvFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFactura.DoubleBuffered = true;
            this.dgvFactura.EnableHeadersVisualStyles = false;
            this.dgvFactura.HeaderBgColor = System.Drawing.Color.SkyBlue;
            this.dgvFactura.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvFactura.Location = new System.Drawing.Point(0, 44);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFactura.Size = new System.Drawing.Size(875, 367);
            this.dgvFactura.TabIndex = 82;
            // 
            // TITULO
            // 
            this.TITULO.HeaderText = "T I T U L O";
            this.TITULO.Name = "TITULO";
            this.TITULO.ReadOnly = true;
            this.TITULO.Width = 209;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "P R E C I O";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            this.PRECIO.Width = 209;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "C A N T I D A D";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.Width = 209;
            // 
            // UBICACION
            // 
            this.UBICACION.HeaderText = "U B I C A C I Ó N";
            this.UBICACION.Name = "UBICACION";
            this.UBICACION.ReadOnly = true;
            this.UBICACION.Width = 209;
            // 
            // ResultadoBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 411);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultadoBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultadoBusqueda";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblInventario;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvFactura;
        private Bunifu.Framework.UI.BunifuImageButton btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBICACION;
    }
}