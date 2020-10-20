using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Comercio
    {
        #region Declaracion de listas de Datos
        public static List<Producto> listaDeProductos;
        public static List<Persona> listaDePersonas;
        public static List<Cliente> listaDeClientes;
        public static List<Empleado> listaDeEmpleados;
        public static Dictionary<string, string> usuarios;
        public static List<Venta> listaDeVentas;
        public static List<ItemCompra> listaDelCarrito;
        #endregion

        #region Propiedades

        /// <summary>
        /// Obtiene el DNI del cliente que realiza la compra en curso
        /// </summary>
        public static string dniNuevoCliente;
        public static string DniNuevoCliente
        {
            get { return dniNuevoCliente; }
            set { dniNuevoCliente = value; }
        }
        /// <summary>
        /// Obtiene el empleado que se encuentra logueado en la sesión activa.
        /// </summary>
        public static Empleado user;
        public static Empleado UsuarioActivo
        {
            get { return user; }
            set { user = value; }
        }

        /// <summary>
        /// Obtiene la lista provisional de Items de compra
        /// </summary>
        public static List<ItemCompra> listCarrito
        {
            get { return listaDelCarrito; }
        }

        /// <summary>
        /// Obtiene la lista de ventas realizadas
        /// </summary>
        public static List<Venta> listVentas
        {
            get { return listaDeVentas; }
        }

        /// <summary>
        /// Obtiene la lista de empleados
        /// </summary>
        public static List<Empleado> listEmpleados
        {
            get { return listaDeEmpleados; }
        }

        /// <summary>
        /// Obtiene la lista de productos
        /// </summary>
        public static List<Producto> listProductos
        {
            get { return listaDeProductos; }
        }
        #endregion

        #region Constructor 

        static Comercio()
        {
            listaDeProductos = new List<Producto>();
            listaDePersonas = new List<Persona>();
            listaDeClientes = new List<Cliente>();
            listaDeEmpleados = new List<Empleado>();
            usuarios = new Dictionary<string, string>();
            listaDeVentas = new List<Venta>();
            listaDelCarrito = new List<ItemCompra>();
        }
        #endregion

        #region Harcodeos
        /// <summary>
        /// Método que carga datos iniciales para probar la solución
        /// </summary>
        public static void Harcodeos()
        {
            Cliente PrimerCliente = new Cliente("Homero", "simpson", 32425312);
            Cliente SegundoCliente = new Cliente("Ned", "flanders", 25789632);
            Cliente TercerCliente = new Cliente("March", "simpson", 14526325);
            listaDeClientes.Add(PrimerCliente);
            listaDeClientes.Add(SegundoCliente);
            listaDeClientes.Add(TercerCliente);

            Empleado PrimerEmpleado = new Empleado("Fineas", "Grant", 32456987, Empleado.EArea.Caja, "fgrant");
            Empleado SegundoEmpleado = new Empleado("Sanjay", "Ganesh", 25418745, Empleado.EArea.Ventas, "sganesh");
            Empleado TercerEmpleado = new Empleado("Kavi", "Kali", 32456987, Empleado.EArea.Gerencia, "kkali");

            listaDeEmpleados.Add(PrimerEmpleado);
            listaDeEmpleados.Add(SegundoEmpleado);
            listaDeEmpleados.Add(TercerEmpleado);

            Producto PrimerProducto = new ProductoPerecedero("Leche", 125, 0, "La veronica");
            Producto SegundoProducto = new ProductoPerecedero("Manteca", 12, 12, "Girasol");
            Producto TercerProducto = new ProductoPerecedero("Jamon", 125, 12, "El cerdito");
            Producto CuartoProducto = new ProductoViveres("Arroz", 49.5f, 2, "3 hermanos");
            Producto QuintoProducto = new ProductoViveres("Azucar", 35.5f, 2, "La dulsura");
            Producto SextoProducto = new ProductoViveres("Harina", 49.5f, 5, "Salinas");
            Producto SeptimoProducto = new ProductoKiosko("Dulce de Leche", 125.2f, 12, "Vauquita");
            Producto OctavoProducto = new ProductoKiosko("Chocolate", 80, 12, "Cacao");
            Producto NovenoProducto = new ProductoKiosko("Alfajor lalala", 45, 1, "Guaymayen");

            listaDeProductos.Add(PrimerProducto);
            listaDeProductos.Add(SegundoProducto);
            listaDeProductos.Add(TercerProducto);
            listaDeProductos.Add(CuartoProducto);
            listaDeProductos.Add(QuintoProducto);
            listaDeProductos.Add(SextoProducto);
            listaDeProductos.Add(SeptimoProducto);
            listaDeProductos.Add(OctavoProducto);
            listaDeProductos.Add(NovenoProducto);

            Venta PrimeraVenta = new Venta(PrimerCliente, PrimerEmpleado, 1235);
            Venta SegundaVenta = new Venta(SegundoCliente, SegundoEmpleado, 1352);
            Venta TerceraVenta = new Venta(TercerCliente, TercerEmpleado, 1500);
            listaDeVentas.Add(PrimeraVenta);
            listaDeVentas.Add(SegundaVenta);
            listaDeVentas.Add(TerceraVenta);


        }

        public static void UsuariosHarcodeo()
        {
            usuarios.Add("fgrant", "1234");
            usuarios.Add("sganesh", "1111");
            usuarios.Add("kkali", "1111");
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Metodo que busca un cliente y devuelve sus datos en formato string
        /// </summary>
        /// <param name="dniCliente">String que representa el dni de Cliente cargado por el usuario</param>
        /// <returns>Devuelve un string con los datos del cliente</returns>
        public static string BuscarClientePorDni(string dniCliente)
        {
            string retValue = "Cliente no Encontrado";

            foreach (Cliente item in listaDeClientes)
            {

                if (int.TryParse(dniCliente, out int auxDni))
                {

                    if (item.dniCliente == auxDni)
                    {
                        retValue = item.Mostrar();
                        break;
                    }

                }

            }

            return retValue;
        }
        /// <summary>
        /// Metodo que busca un cliente en la lista de clientes y lo devuelve
        /// </summary>
        /// <param name="dniCliente">String que representa el dni de Cliente cargado por el usuario</param>
        /// <returns>Devuelve un objeto de tipo Cliente</returns>
        public static Cliente DevolverClientePorDni(string dniCliente)
        {
            Cliente retValue = null;

            foreach (Cliente item in listaDeClientes)
            {

                if (int.TryParse(dniCliente, out int auxDni))
                {

                    if (item.dniCliente == auxDni)
                    {
                        retValue = item;
                        return retValue;
                    }

                }

            }
            return retValue;
        }
        /// <summary>
        /// Método para validar el Login comparando los parametros "usuario" y "contrasenia" contra sus pares
        /// respectivos en el diccionario de usuarios
        /// </summary>
        /// <param name="usuario">String que representa el usuario cargado por el usuario</param>
        /// <param name="contrasenia">String que representa el password cargado por el usuario</param>
        /// <returns>Devuelve un booleano. True si se encontro coincidencia</returns>
        public static bool ValidarLogin(string usuario, string contrasenia)
        {
            bool retValue = false;

            foreach (var item in usuarios)
            {

                if (item.Key == usuario && item.Value == contrasenia)
                {
                    retValue = true;
                    return retValue;
                }

            }

            return retValue;
        }
        /// <summary>
        /// Método que actualiza la cantidad de un producto en la lista de productos
        /// </summary>
        /// <param name="productoseleccionadoId">Entero que representa el id del producto seleccionado</param>
        /// <param name="cantidadamodificar">Entero que representa la cantidad a restar</param>
        /// <returns>Devuelve un booleano para control de ejecucion</returns>
        public static bool ModificarCantidad(int productoseleccionadoId, int cantidadamodificar)
        {
            bool retValue = false;

            if (productoseleccionadoId > 0 && cantidadamodificar > 0)
            {

                for (int i = 0; i < Comercio.listaDeProductos.Count; i++)
                {
                    if (Comercio.listaDeProductos[i].IdProducto == productoseleccionadoId)
                    {
                        Comercio.listaDeProductos[i].Cantidad -= cantidadamodificar;
                    }
                }
                retValue = true;
            }

            return retValue;
        }
        /// <summary>
        /// Método que devuelve un elemento de la lista de productos. 
        /// </summary>
        /// <param name="idProducto">Entero que representa el id de un producto determinado</param>
        /// <returns>Devuelve un objeto de tipo Producto</returns>
        public static Producto buscarProductoPorId(int idProducto)
        {
            Producto auxProducto = null;
            for (int i = 0; i < Comercio.listaDeProductos.Count; i++)
            {
                if (Comercio.listaDeProductos[i].IdProducto == idProducto)
                {
                    auxProducto = Comercio.listaDeProductos[i];
                }
            }
            return auxProducto;
        }
        /// <summary>
        /// Método que devuelve el id de un producto dado.
        /// </summary>
        /// <param name="productoSeleccionado">Objeto de tipo producto que contiene el producto a buscar</param>
        /// <returns>Devuelve un entero que representa el Id de producto</returns>
        public static int buscarProductoEnlista(Producto productoSeleccionado)
        {
            int retValue = -1;

            foreach (Producto item in Comercio.listaDeProductos)
            {
                if (item == productoSeleccionado)
                {
                    retValue = item.IdProducto;
                    return retValue;
                }
            }

            return retValue;
        }
        /// <summary>
        /// Método que calcula el monto total de venta de los items de compra cargados en la lista de ItemCompra
        /// </summary>
        /// <param name="productosSeleccionadosCarrito">Lista de objetos ItemCompra seleccionados en la venta actual</param>
        /// <returns>Devuelve un float que representa el monto total de la venta actual</returns>
        public static float CalcularMontoVenta(List<ItemCompra> productosSeleccionadosCarrito)
        {
            float total = 0;
            for (int i = 0; i < productosSeleccionadosCarrito.Count; i++)
            {
                total += productosSeleccionadosCarrito[i].cantidad * productosSeleccionadosCarrito[i].PrecioItem;
            }

            return total;
        }
        /// <summary>
        /// Método que resta el 13% al monto total de venta si un cliente es de apellido "simpson"
        /// </summary>
        /// <param name="productosSeleccionadosCarrito">Lista de objetos ItemCompra seleccionados en la venta actual</param>
        /// <param name="clienteActual">Objeto de tipo cliente que representa al cliente que esta realizando la compra</param>
        /// <returns>Devuelve un float que representa el monto final de venta</returns>
        public static float CalcularDescuentoSimpson(List<ItemCompra> productosSeleccionadosCarrito, Cliente clienteActual)
        {
            float total = 0;
            for (int i = 0; i < productosSeleccionadosCarrito.Count; i++)
            {
                total += productosSeleccionadosCarrito[i].cantidad * productosSeleccionadosCarrito[i].PrecioItem;
            }

            if (clienteActual.Apellido == "simpson")
            {
                total = total * 0.87F;
            }
            return total;
        }
        /// <summary>
        /// Método que busca el empleado que esta logueado en la aplicacion dentro en la lista de Empleados
        /// </summary>
        /// <param name="usuario">String que representa el usuario del empleado que se encuentra logueado en la aplicacion</param>
        /// <returns>Devuelve un objeto de tipo Empleado</returns>
        public static Empleado BusacarEmpleadoPorUsuario(string usuario)
        {
            Empleado auxEmpleado = null;

            foreach (Empleado item in listaDeEmpleados)
            {

                if (item.Usuario == usuario)
                {
                    auxEmpleado = item;
                }
            }
            return auxEmpleado;
        }
        /// <summary>
        /// Método que valida si la cantidad solicitada del producto es igual o menor a la existente en stock
        /// </summary>
        /// <param name="idProductoAValidar">Entero que representa el id del producto a validar</param>
        /// <param name="cantidaProductoSeleccionado">Entero que representa la cantidad requerida del producto</param>
        public static void ConfirmarStock(int idProductoAValidar, int cantidaProductoSeleccionado)
        {
            StockException ex = new StockException("No hay suficiente stock");

            foreach (Producto item in listProductos)
            {
                if (item.IdProducto == idProductoAValidar)
                {
                    if (item.Cantidad > 0)
                    {
                        if (cantidaProductoSeleccionado <= item.Cantidad)
                        {
                            continue;
                        }
                        else
                        {
                            throw ex;
                        }
                    }
                    else
                    {
                        throw ex;
                    }
                }
            }
        }
        /// <summary>
        /// Método que utiliza de manera diferenciada los constructores de las clases derivadas de producto y genera nuevas instancias para ser añadidas a una lista de productos.
        /// </summary>
        /// <param name="nombre">String que representa el nombre del producto</param>
        /// <param name="precioUnitario">float que representa el precio unitario del producto</param>
        /// <param name="cantidad">entero que representa la cantidad del producto a cargar</param>
        /// <param name="marca">String que representa la marca del producto</param>
        /// <param name="tipoDeProducto">string que representa el tipo de producto seleccionado por el usuario</param>
        /// <param name="listaAñadirProducto">Lista de productos a la que se quiere agregar la nueva instancia</param>
        /// <returns></returns>
        public static bool AltaDeProductoPorTipo(string nombre, float precioUnitario, int cantidad, string marca, string tipoDeProducto, List<Producto> listaAñadirProducto)
        {
            bool retValue = false;
            switch (tipoDeProducto)
            {
                case ("Kiosco"):
                    ProductoKiosko nuevoProductoKiosko = new ProductoKiosko(nombre, precioUnitario, cantidad, marca);
                    listaAñadirProducto.Add(nuevoProductoKiosko);
                    retValue = true;
                    break;
                case ("Perecedero"):
                    ProductoPerecedero nuevoProductoPerecedero = new ProductoPerecedero(nombre, precioUnitario, cantidad, marca);
                    listaAñadirProducto.Add(nuevoProductoPerecedero);
                    retValue = true;
                    break;
                case ("Viveres"):
                    ProductoViveres nuevoProductoViveres = new ProductoViveres(nombre, precioUnitario, cantidad, marca);
                    listaAñadirProducto.Add(nuevoProductoViveres);
                    retValue = true;
                    break;
                default:
                    retValue = false;
                    break;
            }
            return retValue;
        }
        #endregion
    }
}
