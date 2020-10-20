using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KwikESalesFE
{
    public partial class MenuDeReportes : Form
    {
        public MenuDeReportes()
        {
            InitializeComponent();
        }

        private void btnStockProductos_Click(object sender, EventArgs e)
        {
            int auxTotal = -1;
            dgvMostrarReportes.ReadOnly = true;
            lblMostrarEmpleado.Text = "";

            dgvMostrarReportes.DataSource = Comercio.listaDeProductos;
            for (int i = 0; i < Comercio.listaDeProductos.Count; i++)
            {
                auxTotal += Comercio.listaDeProductos[i].Cantidad;
            }
            lblTotalDeProductos.Text = String.Concat("Stock total de Productos: ", auxTotal.ToString());
        }

        private void btnProductosMenorStock_Click(object sender, EventArgs e)
        {
            dgvMostrarReportes.ReadOnly = true;
            lblMostrarEmpleado.Text = "";
            List<Producto> subListaProductos = new List<Producto>();

            for (int i = 0; i < Comercio.listaDeProductos.Count; i++)
            {
                if (Comercio.listaDeProductos[i].Cantidad < 10)
                {
                    subListaProductos.Add(Comercio.listaDeProductos[i]);
                }
            }

            dgvMostrarReportes.DataSource = null;
            dgvMostrarReportes.DataSource = subListaProductos;
        }

        private void btnComprasEmpleado_Click(object sender, EventArgs e)
        {
            dgvMostrarReportes.ReadOnly = false;
            dgvMostrarReportes.DataSource = Comercio.listEmpleados;
            lblMostrarEmpleado.Text = "Haga doble click en el empleado para mostrar las ventas";
        }

        /// <summary>
        /// Método que arma una sublista de ventas en las que se encuentre el empleado seleccionado por el usuario mediante el evento CellContentDoubleClick
        /// </summary>
        /// <param name="unEmpleado">Objeto de tipo Empleado</param>
        public void MostrarVentasEmpleado(Empleado unEmpleado)
        {
            List<Venta> subListaVentas = new List<Venta>();

            for (int i = 0; i < Comercio.listaDeVentas.Count; i++)
            {
                if (Comercio.listaDeVentas[i].ElEmpleadoId == unEmpleado.idEmpleado)
                {
                    subListaVentas.Add(Comercio.listaDeVentas[i]);
                }
            }
            dgvMostrarReportes.DataSource = null;
            dgvMostrarReportes.DataSource = subListaVentas;
        }

        private void dgvMostrarReportes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMostrarReportes.ReadOnly == false)
            {
                Empleado auxEmpleado = (Empleado)dgvMostrarReportes.CurrentRow.DataBoundItem;
                MostrarVentasEmpleado(auxEmpleado);
                dgvMostrarReportes.ReadOnly = true;
            }
        }
    }
}
