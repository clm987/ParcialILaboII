using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos y Propiedades
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected static int codigoDeEmpleado = 1;
        protected static int codigoDeCliente = 1;

        public abstract int Dni
        {
            get;
        }

        public abstract string NombreyApellido
        {
            get;
        }

        public abstract string Apellido
        {
            get;
        }
        #endregion

        #region Constructores
        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método virtual que permite devolver los datos de un Persona en tipo string
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        #endregion

        #region Sobrecarga de Tipo
        /// <summary>
        /// Sobrecarga explicita del tipo string. 
        /// </summary>
        /// <param name="unaPersona"></param>
        public static explicit operator string(Persona unaPersona)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {unaPersona.nombre}");
            sb.AppendLine($"Apellido: {unaPersona.apellido}");
            sb.AppendLine($"Documento: {unaPersona.dni.ToString()}");

            return sb.ToString();
        }
        #endregion
    }
}
