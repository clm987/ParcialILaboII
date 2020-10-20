namespace KwikESalesFE
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.btnIngresarProducto = new System.Windows.Forms.Button();
            this.btnReportesVarios = new System.Windows.Forms.Button();
            this.menuDesplegable = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesVariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProductoNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDesplegable.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.Location = new System.Drawing.Point(559, 30);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(135, 38);
            this.btnNuevaVenta.TabIndex = 2;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = false;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // btnIngresarProducto
            // 
            this.btnIngresarProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIngresarProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIngresarProducto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarProducto.Location = new System.Drawing.Point(348, 30);
            this.btnIngresarProducto.Name = "btnIngresarProducto";
            this.btnIngresarProducto.Size = new System.Drawing.Size(135, 38);
            this.btnIngresarProducto.TabIndex = 1;
            this.btnIngresarProducto.Text = "Administrar Stock";
            this.btnIngresarProducto.UseVisualStyleBackColor = false;
            this.btnIngresarProducto.Click += new System.EventHandler(this.btnIngresarProducto_Click);
            // 
            // btnReportesVarios
            // 
            this.btnReportesVarios.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReportesVarios.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesVarios.Location = new System.Drawing.Point(140, 30);
            this.btnReportesVarios.Name = "btnReportesVarios";
            this.btnReportesVarios.Size = new System.Drawing.Size(135, 38);
            this.btnReportesVarios.TabIndex = 0;
            this.btnReportesVarios.Text = "Reportes Varios";
            this.btnReportesVarios.UseVisualStyleBackColor = false;
            this.btnReportesVarios.Click += new System.EventHandler(this.btnReportesVarios_Click);
            // 
            // menuDesplegable
            // 
            this.menuDesplegable.BackColor = System.Drawing.Color.SkyBlue;
            this.menuDesplegable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem});
            this.menuDesplegable.Location = new System.Drawing.Point(0, 0);
            this.menuDesplegable.Name = "menuDesplegable";
            this.menuDesplegable.Size = new System.Drawing.Size(800, 24);
            this.menuDesplegable.TabIndex = 3;
            this.menuDesplegable.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesVariosToolStripMenuItem1,
            this.ingresarProductoNuevoToolStripMenuItem,
            this.nuevaVentaToolStripMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            // 
            // reportesVariosToolStripMenuItem1
            // 
            this.reportesVariosToolStripMenuItem1.Name = "reportesVariosToolStripMenuItem1";
            this.reportesVariosToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.reportesVariosToolStripMenuItem1.Text = "Reportes Varios";
            this.reportesVariosToolStripMenuItem1.Click += new System.EventHandler(this.btnReportesVarios_Click);
            // 
            // ingresarProductoNuevoToolStripMenuItem
            // 
            this.ingresarProductoNuevoToolStripMenuItem.Name = "ingresarProductoNuevoToolStripMenuItem";
            this.ingresarProductoNuevoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.ingresarProductoNuevoToolStripMenuItem.Text = "Ingresar Producto Nuevo";
            this.ingresarProductoNuevoToolStripMenuItem.Click += new System.EventHandler(this.btnIngresarProducto_Click);
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::KwikESalesFE.Properties.Resources.Exterior;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReportesVarios);
            this.Controls.Add(this.btnIngresarProducto);
            this.Controls.Add(this.btnNuevaVenta);
            this.Controls.Add(this.menuDesplegable);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuDesplegable;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KwikESales";
            this.Load += new System.EventHandler(this.menuPrincipal_Load);
            this.menuDesplegable.ResumeLayout(false);
            this.menuDesplegable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Button btnIngresarProducto;
        private System.Windows.Forms.Button btnReportesVarios;
        private System.Windows.Forms.MenuStrip menuDesplegable;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesVariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ingresarProductoNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
    }
}

