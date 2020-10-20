using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        #region Atributos y propiedades
        protected string nombre;
        protected string marca;
        protected float precioUnitario;
        protected static int codigoDeProducto = 1;
        protected int cantidad;

        public abstract int IdProducto
        {
            get;
        }

        public abstract string Nombre
        {
            get;
        }

        public abstract string Marca
        {
            get;
        }

        public abstract float PrecioUnitario
        {
            get;
        }

        public abstract int Cantidad
        {
            set;
            get;
        }

        public abstract ETipoDeProducto TipoDeProducto
        {
            get;
        }
        #endregion

        #region Enumerado
        public enum ETipoDeProducto
        {
            Kiosco,
            Perecedero,
            Viveres
        }
        #endregion

        #region Constructores
        public Producto(string nombre, float precioUnitario, int cantidad, string marca)
        {
            this.nombre = nombre;
            this.precioUnitario = precioUnitario;
            this.cantidad = cantidad;
            this.marca = marca;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método virtual que permite devolver los datos de un Producto en tipo string
        /// </summary>
        /// <returns>string que contiene los datos del producto</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        #endregion

        #region Sobrecarga de Tipo
        /// <summary>
        /// Sobrecarga explicita del tipo de dato string sobre los atributos de un objeto de tipo Producto
        /// </summary>
        /// <param name="unProducto">Objeto de tipo producto</param>
        public static explicit operator string(Producto unProducto)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre de producto: {unProducto.nombre}");
            sb.AppendLine($"Marca de producto:  {unProducto.marca}");
            sb.AppendLine($"Precio por unidad: {unProducto.precioUnitario.ToString()}");

            return sb.ToString();
        }
        #endregion

        #region Sobrecarga de Operadores

        /// <summary>
        /// Sobrecarga del operador == para validar si dos Productos son iguales a partir del atributo Id
        /// </summary>
        /// <param name="listaDeProductos">Lista de objetos de tipo producto</param>
        /// <param name="unProducto">Objeto de tipo prodcuto</param>
        /// <returns></returns>
        public static bool operator ==(List<Producto> listaDeProductos, Producto unProducto)
        {
            bool retValue = false;

            for (int i = 0; i < listaDeProductos.Count; i++)
            {
                if (listaDeProductos[i].IdProducto == unProducto.IdProducto)
                {
                    retValue = true;
                }
            }

            return retValue;
        }
        /// <summary>
        /// Sobrecarga del operador != para validar si dos Productos NO son iguales a partir del atributo Id
        /// </summary>
        /// <param name="unProductoV">Lista de objetos de tipo producto</param>
        /// <param name="otroProductoV">Objeto de tipo prodcuto</param>
        /// <returns></returns>
        public static bool operator !=(List<Producto> listaDeProductos, Producto unProducto)
        {
            return !(listaDeProductos == unProducto);
        }
        #endregion
    }
}
