using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ItemCompra
    {
        #region Atributos y Propiedades
        public string nombre;
        public string marca;
        public float precioUnitario;
        public int codigoDeProducto;
        public int cantidad;

        public string NombreItem
        {
            get { return nombre; }
        }
        public string MarcaItem
        {
            get { return marca; }
        }
        public float PrecioItem
        {
            get { return precioUnitario; }
        }
        public int CodigoItem
        {
            get { return codigoDeProducto; }
        }
        public int CantidadItem
        {
            get { return cantidad; }
        }
        #endregion

        #region Constructor
        public ItemCompra(string nombre, string marca, float precio, int idProducto, int cantidad)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.precioUnitario = precio;
            this.codigoDeProducto = idProducto;
            this.cantidad = cantidad;
        }
        #endregion
    }
}
