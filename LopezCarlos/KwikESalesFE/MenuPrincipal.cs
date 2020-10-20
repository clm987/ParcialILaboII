using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Media;

namespace KwikESalesFE
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();

        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {
            Comercio.Harcodeos();
            //Habilita una instancia del formulario de Login para validar datos de ingreso
            Login ventanaLogin = new Login();
            ventanaLogin.ShowDialog();
            if (ventanaLogin.DialogResult == DialogResult.OK)
            {
                MenuPrincipal nuevoInicio = new MenuPrincipal();
            }
            else
            {
                this.Close();
            }
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            //Habilita una instancia del formulario de MenuDeVentas para procesar una venta
            MenuDeVentas AuxMenuDeVentas = new MenuDeVentas();
            AuxMenuDeVentas.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                AuxMenuDeVentas.Close();
            }
        }

        private void btnIngresarProducto_Click(object sender, EventArgs e)
        {
            //Habilita una instancia del formulario de IncrementarStockProducto para manejar el stock
            IncrementarStockProducto auxVentanaIncrementar = new IncrementarStockProducto();
            auxVentanaIncrementar.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Producto ingresado con exito");
                auxVentanaIncrementar.Close();
            }


        }

        private void btnReportesVarios_Click(object sender, EventArgs e)
        {
            //Habilita una instancia del formulario de MenuDeReportes para ver los distintos repostes
            MenuDeReportes auxMenuDeReportes = new MenuDeReportes();
            auxMenuDeReportes.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                auxMenuDeReportes.Close();
            }
        }
    }
}
