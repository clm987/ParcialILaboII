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

namespace KwikESalesFE
{
    public partial class IncrementarStockProducto : Form
    {
        Producto AuxProducto;
        public IncrementarStockProducto()
        {
            InitializeComponent();
        }

        private void IncrementarStockProducto_Load(object sender, EventArgs e)
        {
            dgvListaDeProductos.DataSource = Comercio.listProductos;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones.validarEntradaCantidad(txtCantidad.Text);
                int auxCantidadProducto;
                int.TryParse(txtCantidad.Text, out auxCantidadProducto);
                if (auxCantidadProducto > 0)
                {
                    //Actualiza el atributo cantidad del producto seleccionado por el usuario
                    AuxProducto.Cantidad += auxCantidadProducto;
                    dgvListaDeProductos.DataSource = Comercio.listaDeProductos;
                    MessageBox.Show(String.Format("Se modifico correctamente el Stock del Producto: {0}", AuxProducto.Nombre));
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    throw new EmptyImputException("La cantidad no puede ser cero");
                }

            }
            catch (EmptyImputException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique los datos ingresados");
            }

        }

        private void btnAltaNuevoProducto_Click(object sender, EventArgs e)
        {
            //Habilita una instancia del formulario AltaNuevoProducto para que el usuario carge los datos
            AltaNuevoProducto auxAltaProducto = new AltaNuevoProducto();
            auxAltaProducto.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                auxAltaProducto.Close();
            }
        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {
            //En funcion de la id ingresada por el usuario o devuelta por el handler del evento CellContentDoubleClick del control dgvListaDeProductos muestra el detalle del producto al usuario
            try
            {
                Validaciones.validarEntradaIdProducto(txtIdProducto.Text);
                int auxIdProdcuto;
                int.TryParse(txtIdProducto.Text, out auxIdProdcuto);
                AuxProducto = Comercio.buscarProductoPorId((auxIdProdcuto));
                lblProductoSeleccionado.Text = AuxProducto.Mostrar();
            }
            catch (EmptyImputException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvListaDeProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Al recibir el evento CellContentDoubleClick busca el producto correspondiente a la fila seleccionada y carga automaticamente los datos Id de producto y muestra el detalle al usuario
            try
            {
                Producto auxProducto = (Producto)dgvListaDeProductos.CurrentRow.DataBoundItem;
                int auxIdProducto = Comercio.buscarProductoEnlista(auxProducto);
                txtIdProducto.Text = auxIdProducto.ToString();
                lblProductoSeleccionado.Text = auxProducto.Mostrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Seleccion incorrecta. Itente de nuevo");
            }
        }
    }
}
