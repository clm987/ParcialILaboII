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
    public partial class AltaNuevoCliente : Form
    {
        public AltaNuevoCliente()
        {
            InitializeComponent();
        }

        private void btnAcepta_Click(object sender, EventArgs e)
        {
            try
            {
                //validacion de datos ingresados por el usuario
                Validaciones.validarEntradaNombrePersona(txtNombreCliente.Text);
                Validaciones.validarEntradaNombrePersona(txtApellidoCliente.Text);
                Validaciones.validarEntradaDni(txtDniCliente.Text);
                int.TryParse(txtDniCliente.Text, out int auxDni);
                if (auxDni > 0)
                {
                    //Crea un nuevo objeto de tipo cliente con los datos ingresados
                    Cliente nuevoCliente = new Cliente(txtNombreCliente.Text, txtApellidoCliente.Text.ToLower(), auxDni);
                    Comercio.listaDeClientes.Add(nuevoCliente);
                    //Carga la propiedad DniNuevoCliente en la clase Comercio para ser recuperada en otros ámbitos
                    Comercio.DniNuevoCliente = (string)txtDniCliente.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    throw new EmptyImputException("El DNI no puede ser cero");
                }

            }
            catch (EmptyImputException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha producido un error valide los datos ingresados");
            }
        }

        private void AltaNuevoCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
