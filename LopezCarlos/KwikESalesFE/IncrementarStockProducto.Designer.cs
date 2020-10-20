namespace KwikESalesFE
{
    partial class IncrementarStockProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncrementarStockProducto));
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.dgvListaDeProductos = new System.Windows.Forms.DataGridView();
            this.lblProductoSeleccionado = new System.Windows.Forms.Label();
            this.btnAltaNuevoProducto = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCantidadAIncrementar = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblMensajeInformativo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.Location = new System.Drawing.Point(39, 39);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(154, 17);
            this.lblIdProducto.TabIndex = 0;
            this.lblIdProducto.Text = "Ingrese el Id del producto";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(246, 39);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(202, 20);
            this.txtIdProducto.TabIndex = 1;
            this.txtIdProducto.TextChanged += new System.EventHandler(this.txtIdProducto_TextChanged);
            // 
            // dgvListaDeProductos
            // 
            this.dgvListaDeProductos.AllowUserToAddRows = false;
            this.dgvListaDeProductos.AllowUserToDeleteRows = false;
            this.dgvListaDeProductos.AllowUserToResizeColumns = false;
            this.dgvListaDeProductos.AllowUserToResizeRows = false;
            this.dgvListaDeProductos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListaDeProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeProductos.Location = new System.Drawing.Point(42, 110);
            this.dgvListaDeProductos.Name = "dgvListaDeProductos";
            this.dgvListaDeProductos.RowHeadersVisible = false;
            this.dgvListaDeProductos.Size = new System.Drawing.Size(406, 121);
            this.dgvListaDeProductos.TabIndex = 2;
            this.dgvListaDeProductos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaDeProductos_CellContentDoubleClick);
            // 
            // lblProductoSeleccionado
            // 
            this.lblProductoSeleccionado.AutoSize = true;
            this.lblProductoSeleccionado.Location = new System.Drawing.Point(39, 234);
            this.lblProductoSeleccionado.Name = "lblProductoSeleccionado";
            this.lblProductoSeleccionado.Size = new System.Drawing.Size(0, 13);
            this.lblProductoSeleccionado.TabIndex = 3;
            // 
            // btnAltaNuevoProducto
            // 
            this.btnAltaNuevoProducto.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaNuevoProducto.Location = new System.Drawing.Point(111, 324);
            this.btnAltaNuevoProducto.Name = "btnAltaNuevoProducto";
            this.btnAltaNuevoProducto.Size = new System.Drawing.Size(97, 46);
            this.btnAltaNuevoProducto.TabIndex = 4;
            this.btnAltaNuevoProducto.Text = "Cargar Nuevo Producto";
            this.btnAltaNuevoProducto.UseVisualStyleBackColor = true;
            this.btnAltaNuevoProducto.Click += new System.EventHandler(this.btnAltaNuevoProducto_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(272, 324);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(97, 46);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCantidadAIncrementar
            // 
            this.lblCantidadAIncrementar.AutoSize = true;
            this.lblCantidadAIncrementar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadAIncrementar.Location = new System.Drawing.Point(39, 78);
            this.lblCantidadAIncrementar.Name = "lblCantidadAIncrementar";
            this.lblCantidadAIncrementar.Size = new System.Drawing.Size(115, 17);
            this.lblCantidadAIncrementar.TabIndex = 6;
            this.lblCantidadAIncrementar.Text = "Ingrese la cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(246, 78);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(202, 20);
            this.txtCantidad.TabIndex = 7;
            // 
            // lblMensajeInformativo
            // 
            this.lblMensajeInformativo.AutoSize = true;
            this.lblMensajeInformativo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMensajeInformativo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMensajeInformativo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeInformativo.Location = new System.Drawing.Point(67, 9);
            this.lblMensajeInformativo.Name = "lblMensajeInformativo";
            this.lblMensajeInformativo.Size = new System.Drawing.Size(334, 22);
            this.lblMensajeInformativo.TabIndex = 8;
            this.lblMensajeInformativo.Text = "Ingrese el ID o haga doble click en el producto";
            // 
            // IncrementarStockProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.lblMensajeInformativo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidadAIncrementar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAltaNuevoProducto);
            this.Controls.Add(this.lblProductoSeleccionado);
            this.Controls.Add(this.dgvListaDeProductos);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.lblIdProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IncrementarStockProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncrementarStockProducto";
            this.Load += new System.EventHandler(this.IncrementarStockProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.DataGridView dgvListaDeProductos;
        private System.Windows.Forms.Label lblProductoSeleccionado;
        private System.Windows.Forms.Button btnAltaNuevoProducto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblCantidadAIncrementar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblMensajeInformativo;
    }
}