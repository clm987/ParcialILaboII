namespace KwikESalesFE
{
    partial class MenuDeVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDeVentas));
            this.txtDni = new System.Windows.Forms.TextBox();
            this.ldlDniCliente = new System.Windows.Forms.Label();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.ddvProductos = new System.Windows.Forms.DataGridView();
            this.dgvResumenCompra = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblMontoVenta = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.lblIntruccionEliminarItem = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ddvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(384, 40);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(265, 20);
            this.txtDni.TabIndex = 0;
            this.txtDni.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ldlDniCliente
            // 
            this.ldlDniCliente.AutoSize = true;
            this.ldlDniCliente.BackColor = System.Drawing.Color.Cornsilk;
            this.ldlDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlDniCliente.Location = new System.Drawing.Point(121, 40);
            this.ldlDniCliente.Name = "ldlDniCliente";
            this.ldlDniCliente.Size = new System.Drawing.Size(213, 20);
            this.ldlDniCliente.TabIndex = 1;
            this.ldlDniCliente.Text = "lngrese el DNI del Cliente";
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.BackColor = System.Drawing.Color.Cornsilk;
            this.lblDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCliente.Location = new System.Drawing.Point(513, 98);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(0, 24);
            this.lblDatosCliente.TabIndex = 2;
            // 
            // ddvProductos
            // 
            this.ddvProductos.AllowUserToAddRows = false;
            this.ddvProductos.AllowUserToDeleteRows = false;
            this.ddvProductos.AllowUserToResizeColumns = false;
            this.ddvProductos.AllowUserToResizeRows = false;
            this.ddvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ddvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ddvProductos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ddvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ddvProductos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ddvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ddvProductos.Location = new System.Drawing.Point(26, 98);
            this.ddvProductos.Name = "ddvProductos";
            this.ddvProductos.ReadOnly = true;
            this.ddvProductos.RowHeadersVisible = false;
            this.ddvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ddvProductos.Size = new System.Drawing.Size(470, 150);
            this.ddvProductos.TabIndex = 3;
            this.ddvProductos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ddvProductos_CellContentDoubleClick);
            // 
            // dgvResumenCompra
            // 
            this.dgvResumenCompra.AllowUserToAddRows = false;
            this.dgvResumenCompra.AllowUserToDeleteRows = false;
            this.dgvResumenCompra.AllowUserToResizeColumns = false;
            this.dgvResumenCompra.AllowUserToResizeRows = false;
            this.dgvResumenCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResumenCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResumenCompra.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvResumenCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResumenCompra.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvResumenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenCompra.Location = new System.Drawing.Point(26, 269);
            this.dgvResumenCompra.Name = "dgvResumenCompra";
            this.dgvResumenCompra.ReadOnly = true;
            this.dgvResumenCompra.RowHeadersVisible = false;
            this.dgvResumenCompra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResumenCompra.Size = new System.Drawing.Size(470, 150);
            this.dgvResumenCompra.TabIndex = 4;
            this.dgvResumenCompra.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResumenCompra_CellContentDoubleClick);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(694, 277);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(56, 20);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.Text = " ";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Cornsilk;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCantidad.Location = new System.Drawing.Point(499, 278);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(189, 16);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Ingrese la cantidad a comprar:";
            // 
            // lblMontoVenta
            // 
            this.lblMontoVenta.AutoSize = true;
            this.lblMontoVenta.BackColor = System.Drawing.Color.Cornsilk;
            this.lblMontoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoVenta.Location = new System.Drawing.Point(571, 316);
            this.lblMontoVenta.Name = "lblMontoVenta";
            this.lblMontoVenta.Size = new System.Drawing.Size(117, 16);
            this.lblMontoVenta.TabIndex = 7;
            this.lblMontoVenta.Text = "Monto de la venta:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.BackColor = System.Drawing.Color.Cornsilk;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(694, 316);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(15, 16);
            this.lblMonto.TabIndex = 8;
            this.lblMonto.Text = "0";
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.BackColor = System.Drawing.Color.CadetBlue;
            this.btnConfirmarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarVenta.Location = new System.Drawing.Point(624, 379);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(118, 40);
            this.btnConfirmarVenta.TabIndex = 9;
            this.btnConfirmarVenta.Text = "Confirmar Venta";
            this.btnConfirmarVenta.UseVisualStyleBackColor = false;
            this.btnConfirmarVenta.Click += new System.EventHandler(this.btnConfirmarVenta_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAltaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCliente.Location = new System.Drawing.Point(665, 34);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(113, 34);
            this.btnAltaCliente.TabIndex = 10;
            this.btnAltaCliente.Text = "Agregar Cliente";
            this.btnAltaCliente.UseVisualStyleBackColor = false;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // lblIntruccionEliminarItem
            // 
            this.lblIntruccionEliminarItem.AutoSize = true;
            this.lblIntruccionEliminarItem.BackColor = System.Drawing.Color.Cornsilk;
            this.lblIntruccionEliminarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntruccionEliminarItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIntruccionEliminarItem.Location = new System.Drawing.Point(23, 251);
            this.lblIntruccionEliminarItem.Name = "lblIntruccionEliminarItem";
            this.lblIntruccionEliminarItem.Size = new System.Drawing.Size(0, 16);
            this.lblIntruccionEliminarItem.TabIndex = 11;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Interior.png");
            // 
            // MenuDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::KwikESalesFE.Properties.Resources.Interior;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIntruccionEliminarItem);
            this.Controls.Add(this.btnAltaCliente);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblMontoVenta);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dgvResumenCompra);
            this.Controls.Add(this.ddvProductos);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.ldlDniCliente);
            this.Controls.Add(this.txtDni);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuDeVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones de Venta";
            this.Load += new System.EventHandler(this.MenuDeVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ddvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label ldlDniCliente;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.DataGridView ddvProductos;
        private System.Windows.Forms.DataGridView dgvResumenCompra;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblMontoVenta;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Label lblIntruccionEliminarItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}