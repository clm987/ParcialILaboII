namespace KwikESalesFE
{
    partial class MenuDeReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDeReportes));
            this.btnComprasEmpleado = new System.Windows.Forms.Button();
            this.btnStockProductos = new System.Windows.Forms.Button();
            this.btnProductosMenorStock = new System.Windows.Forms.Button();
            this.dgvMostrarReportes = new System.Windows.Forms.DataGridView();
            this.lblTotalDeProductos = new System.Windows.Forms.Label();
            this.lblMostrarEmpleado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComprasEmpleado
            // 
            this.btnComprasEmpleado.Location = new System.Drawing.Point(299, 53);
            this.btnComprasEmpleado.Name = "btnComprasEmpleado";
            this.btnComprasEmpleado.Size = new System.Drawing.Size(152, 35);
            this.btnComprasEmpleado.TabIndex = 1;
            this.btnComprasEmpleado.Text = "Mostrar Ventas por Empleado";
            this.btnComprasEmpleado.UseVisualStyleBackColor = true;
            this.btnComprasEmpleado.Click += new System.EventHandler(this.btnComprasEmpleado_Click);
            // 
            // btnStockProductos
            // 
            this.btnStockProductos.Location = new System.Drawing.Point(87, 53);
            this.btnStockProductos.Name = "btnStockProductos";
            this.btnStockProductos.Size = new System.Drawing.Size(152, 35);
            this.btnStockProductos.TabIndex = 0;
            this.btnStockProductos.Text = "Mostrar Stock de Productos";
            this.btnStockProductos.UseVisualStyleBackColor = true;
            this.btnStockProductos.Click += new System.EventHandler(this.btnStockProductos_Click);
            // 
            // btnProductosMenorStock
            // 
            this.btnProductosMenorStock.Location = new System.Drawing.Point(516, 53);
            this.btnProductosMenorStock.Name = "btnProductosMenorStock";
            this.btnProductosMenorStock.Size = new System.Drawing.Size(152, 35);
            this.btnProductosMenorStock.TabIndex = 2;
            this.btnProductosMenorStock.Text = "Mostrar Productos Stock menor  a 10";
            this.btnProductosMenorStock.UseVisualStyleBackColor = true;
            this.btnProductosMenorStock.Click += new System.EventHandler(this.btnProductosMenorStock_Click);
            // 
            // dgvMostrarReportes
            // 
            this.dgvMostrarReportes.AllowUserToAddRows = false;
            this.dgvMostrarReportes.AllowUserToDeleteRows = false;
            this.dgvMostrarReportes.AllowUserToResizeColumns = false;
            this.dgvMostrarReportes.AllowUserToResizeRows = false;
            this.dgvMostrarReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrarReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarReportes.Location = new System.Drawing.Point(77, 158);
            this.dgvMostrarReportes.Name = "dgvMostrarReportes";
            this.dgvMostrarReportes.RowHeadersVisible = false;
            this.dgvMostrarReportes.Size = new System.Drawing.Size(591, 150);
            this.dgvMostrarReportes.TabIndex = 3;
            this.dgvMostrarReportes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarReportes_CellContentDoubleClick);
            // 
            // lblTotalDeProductos
            // 
            this.lblTotalDeProductos.AutoSize = true;
            this.lblTotalDeProductos.Location = new System.Drawing.Point(516, 139);
            this.lblTotalDeProductos.Name = "lblTotalDeProductos";
            this.lblTotalDeProductos.Size = new System.Drawing.Size(0, 13);
            this.lblTotalDeProductos.TabIndex = 4;
            // 
            // lblMostrarEmpleado
            // 
            this.lblMostrarEmpleado.AutoSize = true;
            this.lblMostrarEmpleado.Location = new System.Drawing.Point(77, 138);
            this.lblMostrarEmpleado.Name = "lblMostrarEmpleado";
            this.lblMostrarEmpleado.Size = new System.Drawing.Size(0, 13);
            this.lblMostrarEmpleado.TabIndex = 5;
            // 
            // MenuDeReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMostrarEmpleado);
            this.Controls.Add(this.lblTotalDeProductos);
            this.Controls.Add(this.dgvMostrarReportes);
            this.Controls.Add(this.btnProductosMenorStock);
            this.Controls.Add(this.btnStockProductos);
            this.Controls.Add(this.btnComprasEmpleado);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuDeReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuDeReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComprasEmpleado;
        private System.Windows.Forms.Button btnStockProductos;
        private System.Windows.Forms.Button btnProductosMenorStock;
        private System.Windows.Forms.DataGridView dgvMostrarReportes;
        private System.Windows.Forms.Label lblTotalDeProductos;
        private System.Windows.Forms.Label lblMostrarEmpleado;
    }
}