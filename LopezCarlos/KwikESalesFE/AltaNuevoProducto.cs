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
    public partial class AltaNuevoProducto : Form
    {
        public AltaNuevoProducto()
        {
            InitializeComponent();
        }

        private void AltaNuevoProducto_Load(object sender, EventArgs e)
        {
            //Carga el control de tipo ComboBox del formulario con el Enum EtipoDeProducto
            cmbTipoProducto.DataSource = Enum.GetValues(typeof(Producto.ETipoDeProducto));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validaciones de datos de entrada
                Validaciones.validarEntradaNombreProducto(txtNombreProducto.Text);
                Validaciones.validarEntradaMarca(txtMarcaProducto.Text);
                Validaciones.validarEntradaPrecio(txtPrecioProducto.Text);
                Validaciones.validarEntradaCantidad(txtCantidadProducto.Text);
                int.TryParse(txtCantidadProducto.Text, out int auxCantidad);
                float.TryParse(txtPrecioProducto.Text, out float auxPrecioUnitario);
                if (auxCantidad > 0 && auxPrecioUnitario > 0)
                {
                    //Pasa los datos necesarios para generar la instacia del prodcuto a ser incluido en la lista
                    if (Comercio.AltaDeProductoPorTipo(txtNombreProducto.Text.Trim(), auxPrecioUnitario, auxCantidad, txtMarcaProducto.Text.Trim(), cmbTipoProducto.Text, Comercio.listaDeProductos))
                    {
                        MessageBox.Show("Producto Agregado Exitosamente");
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    throw new EmptyImputException("La cantidad y el precio deben ser mayores a cero");
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
    }
}


